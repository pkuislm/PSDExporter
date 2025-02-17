using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Reflection;
using PsdParser;
using SixLabors.ImageSharp;
using SixLabors.ImageSharp.Formats.Jpeg;
using SixLabors.ImageSharp.Formats.Png;
using SixLabors.ImageSharp.Formats.Webp;
using SixLabors.ImageSharp.Metadata.Profiles.Exif;
using SixLabors.ImageSharp.PixelFormats;
using SixLabors.ImageSharp.Processing;
using Image = SixLabors.ImageSharp.Image;

namespace PSDExporter
{
    public partial class ExportProgress : Form
    {
        public class ProgressInfo
        {
            public string? Status { get; set; }
            public string? CurrentFile { get; set; }
            public bool IsRemove { get; set; }
            public int OverallProgress { get; set; }
            public int Total { get; set; }
        }
        readonly int maxConcurrentExports = 4; // 最大并发数

        public int ExportFormat = 0;
        public string ExportPath = "";
        public int ColorProfile = 0;
        public int JPGExportQuality = 100;
        public int PngCompressLevel = 9;

        public bool WebpExportMode = true;
        public bool WebpNearLossless = true;
        public int WebpEntropyPasses = 1;
        public int WebpEncodingMethod = 0;
        public int WebpNearLosslessQuality = 100;
        public int WebpQuality = 100;

        public string CopyRightStr = "";
        public string SoftwareStr = "";
        public string ArtistStr = "";
        public string DescriptionStr = "";

        public bool GrayMode = false;
        
        public List<string> PSDPath = [];

        const string DateTimeFormat = "yyyy:MM:dd HH:mm:ss";

        private readonly CancellationTokenSource _cancellationTokenSource = new();

        public ExportProgress()
        {
            InitializeComponent();
        }

        private void StopExportButtonClick(object sender, EventArgs e)
        {
            if (MessageBox.Show("你要终止导出吗？", "导出", MessageBoxButtons.YesNo) == DialogResult.Yes) 
            {
                _cancellationTokenSource.Cancel();
                DialogResult = DialogResult.Cancel;
            }
        }
        private void ReportProgress(ProgressInfo info)
        {
            if(info.Status != null)
                label1.Text = info.Status;
            if(info.CurrentFile != null)
            {
                if(info.IsRemove)
                {
                    listBox1.Items.RemoveAt(listBox1.Items.IndexOf(info.CurrentFile));
                }
                else
                {
                    listBox1.Items.Add(info.CurrentFile);
                }
            }
            if(info.OverallProgress == -1)
            {
                progressBar1.Style = ProgressBarStyle.Marquee;
                progressBar1.MarqueeAnimationSpeed = 25;
            }
            else if(info.OverallProgress >= 0)
            {
                if(progressBar1.Style != ProgressBarStyle.Continuous)
                {
                    progressBar1.Style = ProgressBarStyle.Continuous;
                    progressBar1.Maximum = info.Total;
                }

                progressBar1.Value = info.OverallProgress;
            }
        }

        private void FormShown(object sender, EventArgs e)
        {
            var token = _cancellationTokenSource.Token;
            var progress = new Progress<ProgressInfo>(ReportProgress);

            ExportImages(progress, token);
            //Task.Run(() => ExportImages(progress, token), token).ContinueWith(t => { Close(); }, TaskScheduler.FromCurrentSynchronizationContext());
        }

        private void ExportImages(IProgress<ProgressInfo> progress, CancellationToken token)
        {
            progress.Report(new ProgressInfo() { Status="正在发现文件...", OverallProgress = -1 });

            List<string> psds = [];

            foreach(var f in PSDPath)
            {
                if (token.IsCancellationRequested)
                {
                    break;
                }

                if (!Path.Exists(f))
                    continue;

                if((File.GetAttributes(f) & FileAttributes.Directory) == FileAttributes.Directory)
                {
                    foreach (var d in Directory.EnumerateFiles(f, "*.psd").OrderBy(f => f))
                    {
                        psds.Add(d);
                        progress.Report(new ProgressInfo() { Status = $"正在发现文件... {Path.GetFileName(f)}", OverallProgress = -2 });
                    }
                }
                else
                {
                    if (f.EndsWith(".psd", StringComparison.CurrentCultureIgnoreCase))
                    {
                        psds.Add(f);
                        progress.Report(new ProgressInfo() { Status = $"正在发现文件... {Path.GetFileName(f)}", OverallProgress = -2 });
                    }
                }
            }

            var p = 0;
            progress.Report(new ProgressInfo() { Status = "正在导出...", Total=psds.Count, OverallProgress = p });
            listBox1.Items.Clear();

            var semaphore = new SemaphoreSlim(maxConcurrentExports);

            var tasks = psds.Select((file, index) => Task.Run(async () =>
            {
                await semaphore.WaitAsync();

                try
                {
                    if (token.IsCancellationRequested)
                    {
                        return;
                    }


                    var psd = new PsdFile(file);
                    var fileName = Path.GetFileNameWithoutExtension(file);

                    progress.Report(new ProgressInfo() { Status = $"正在导出... ({p}/{psds.Count})", CurrentFile = $"Thread [{Environment.CurrentManagedThreadId}]: {fileName}", OverallProgress = p, IsRemove = false });
                    Image? img = null;

                    byte[]? GetImageWithChCount(int channelCount)
                    {
                        var channelImageData = psd.ImageDataSection.GetData(psd.Header);
                        if (psd.Header.Channels < channelCount)
                        {
                            throw new Exception("Insufficient channel count.");
                        }
                        //Discard pixeldata if necessary
                        else if (psd.Header.Channels != channelCount)
                        {
                            var pixelCount = psd.Header.Width * psd.Header.Height;

                            var newPixelData = new byte[pixelCount * channelCount];
                            var oldPixelIdx = 0;
                            var newPixelIdx = 0;
                            while (oldPixelIdx < pixelCount * psd.Header.Channels)
                            {
                                Buffer.BlockCopy(channelImageData, oldPixelIdx, newPixelData, newPixelIdx, channelCount);
                                oldPixelIdx += psd.Header.Channels;
                                newPixelIdx += channelCount;
                            }
                            return newPixelData;
                        }
                        else
                        {
                            return channelImageData;
                        }
                    }

                    switch (psd.Header.ColorMode)
                    {
                        case ColorMode.RGB:
                        {
                            img = Image.LoadPixelData<Rgb24>(GetImageWithChCount(3), psd.Header.Width, psd.Header.Height);
                            break;
                        }
                        case ColorMode.Grayscale:
                        {
                            img = Image.LoadPixelData<L8>(GetImageWithChCount(1), psd.Header.Width, psd.Header.Height);
                            break;
                        }
                    }

                    Trace.Assert(img != null);

                    if (GrayMode == true)
                        img.Mutate(x => x.Grayscale());

                    img.Metadata.ExifProfile = new ExifProfile();

                    var now = DateTime.Now.ToString(DateTimeFormat);
                    img.Metadata.ExifProfile.SetValue(ExifTag.DateTimeOriginal, now);

                    if (CopyRightStr != "")
                        img.Metadata.ExifProfile.SetValue(ExifTag.Copyright, CopyRightStr);
                    if (SoftwareStr != "")
                        img.Metadata.ExifProfile.SetValue(ExifTag.Software, SoftwareStr);
                    if (ArtistStr != "")
                        img.Metadata.ExifProfile.SetValue(ExifTag.Artist, ArtistStr);
                    if (DescriptionStr != "")
                        img.Metadata.ExifProfile.SetValue(ExifTag.ImageDescription, DescriptionStr);

                    if (ColorProfile < 3)//None
                    {
                        if(ColorProfile == 1 && (GrayMode || psd.Header.ColorMode == ColorMode.Grayscale))
                        {
                            //sGray
                            img.Metadata.IccProfile = new(ICCProfileProvider.ICCProfile[3]);
                        }
                        else
                        {
                            img.Metadata.IccProfile = new(ICCProfileProvider.ICCProfile[ColorProfile]);
                        }
                    }

                    switch (ExportFormat)
                    {
                        case 0:
                        {
                            JpegEncodingColor c = (GrayMode == true) ? JpegEncodingColor.Luminance : psd.Header.ColorMode switch
                            {
                                ColorMode.Grayscale => JpegEncodingColor.Luminance,
                                _ => JpegEncodingColor.YCbCrRatio444
                            };
                            await img.SaveAsJpegAsync(Path.Combine(ExportPath, $"{fileName}.jpg"), new JpegEncoder() { Quality = JPGExportQuality, ColorType = c });
                            break;
                        }
                        case 1:
                        {
                            PngColorType c = (GrayMode == true) ? PngColorType.Grayscale : psd.Header.ColorMode switch
                            {
                                ColorMode.Grayscale => PngColorType.Grayscale,
                                _ => PngColorType.Rgb
                            };
                            await img.SaveAsPngAsync(Path.Combine(ExportPath, $"{fileName}.png"), new PngEncoder() { CompressionLevel = (PngCompressionLevel)PngCompressLevel, ColorType = c });
                            break;
                        }
                        case 2:
                        {
                            await img.SaveAsWebpAsync(Path.Combine(ExportPath, $"{fileName}.webp"), new WebpEncoder() { EntropyPasses = WebpEntropyPasses, NearLossless = WebpNearLossless, NearLosslessQuality = WebpNearLosslessQuality, Method = (WebpEncodingMethod)WebpEncodingMethod, Quality = WebpQuality, FileFormat = WebpExportMode ? WebpFileFormatType.Lossless : WebpFileFormatType.Lossy });
                            break;
                        }
                        default:
                            throw new NotSupportedException("Unknown export format.");
                    }
                    img?.Dispose();
                    psd?.Dispose();
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                    p++;
                    progress.Report(new ProgressInfo() { Status = $"正在导出... ({p}/{psds.Count})", CurrentFile = $"Thread [{Environment.CurrentManagedThreadId}]: {fileName}", OverallProgress = p, IsRemove = true });
                }
                finally
                {
                    semaphore.Release();
                }
            }, token)).ToArray();


            Task.WhenAll(tasks).ContinueWith(t =>
            {
                DialogResult = token.IsCancellationRequested ? DialogResult.Cancel : DialogResult.OK;
                Close();
            }, TaskScheduler.FromCurrentSynchronizationContext());
        }
    }
}
