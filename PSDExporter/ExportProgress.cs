using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using PsdParser;
using SixLabors.ImageSharp;
using SixLabors.ImageSharp.Formats.Jpeg;
using SixLabors.ImageSharp.Formats.Png;
using SixLabors.ImageSharp.Metadata.Profiles.Exif;
using SixLabors.ImageSharp.PixelFormats;
using Image = SixLabors.ImageSharp.Image;

namespace PSDExporter
{
    public partial class ExportProgress : Form
    {
        public class ProgressInfo
        {
            public string? Status { get; set; }
            public string? CurrentFile { get; set; }
            public int OverallProgress { get; set; }
            public int Total { get; set; }
        }

        public int ExportFormat = 0;
        public string ExportPath = "";
        public int ColorProfile = 0;
        public int JPGExportQuality = 100;
        public int PngCompressLevel = 9;

        public string CopyRightStr = "";
        public string SoftwareStr = "";
        public string ArtistStr = "";
        public string DescriptionStr = "";

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
                label2.Text = info.CurrentFile;
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

            Task.Run(() => ExportImages(progress, token), token).ContinueWith(t => { Close(); }, TaskScheduler.FromCurrentSynchronizationContext());
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
                        progress.Report(new ProgressInfo() { CurrentFile = d, OverallProgress = -2 });
                    }
                }
                else
                {
                    if (f.EndsWith(".psd", StringComparison.CurrentCultureIgnoreCase))
                    {
                        psds.Add(f);
                        progress.Report(new ProgressInfo() { CurrentFile = f, OverallProgress = -2 });
                    }
                }
            }

            var p = 0;
            progress.Report(new ProgressInfo() { Status = "正在导出...", Total=psds.Count, OverallProgress = p });
            foreach(var file in psds)
            {
                if (token.IsCancellationRequested)
                {
                    break;
                }
                progress.Report(new ProgressInfo() { Status = $"正在导出... ({p}/{psds.Count})", CurrentFile = file, OverallProgress = p });

                using var psd = new PsdFile(file);
                var fileName = Path.GetFileNameWithoutExtension(file);

                var imageData = psd.ImageDataSection.GetData(psd.Header);
                Image img = null;
                switch (psd.Header.ColorMode)
                {
                    case ColorMode.RGB:
                    {
                        switch (psd.Header.Channels)
                        {
                            case 3:
                            {
                                img = Image.LoadPixelData<Rgb24>(imageData, psd.Header.Width, psd.Header.Height);
                                break;
                            }
                            case 4:
                            {
                                img = Image.LoadPixelData<Rgba32>(imageData, psd.Header.Width, psd.Header.Height);
                                break;
                            }
                            default:
                                throw new NotSupportedException();
                        }
                        break;
                    }
                    case ColorMode.Grayscale:
                    {
                        switch (psd.Header.Channels)
                        {
                            case 1:
                            {
                                img = Image.LoadPixelData<L8>(imageData, psd.Header.Width, psd.Header.Height);
                                break;
                            }
                            case 2:
                            {
                                img = Image.LoadPixelData<La16>(imageData, psd.Header.Width, psd.Header.Height);
                                break;
                            }
                            default:
                                throw new NotSupportedException();
                        }
                        break;
                    }
                }

                Trace.Assert(img != null);

                img.Metadata.ExifProfile = new ExifProfile();

                var now = DateTime.Now.ToString(DateTimeFormat);
                img.Metadata.ExifProfile.SetValue(ExifTag.DateTimeOriginal, now);

                if (CopyRightStr != "")
                    img.Metadata.ExifProfile.SetValue(ExifTag.Copyright, CopyRightStr);
                if(SoftwareStr != "")
                    img.Metadata.ExifProfile.SetValue(ExifTag.Software, SoftwareStr);
                if(ArtistStr != "")
                    img.Metadata.ExifProfile.SetValue(ExifTag.Artist, ArtistStr);
                if(DescriptionStr != "")
                    img.Metadata.ExifProfile.SetValue(ExifTag.ImageDescription, DescriptionStr);

                if(ColorProfile < 3)//None
                {
                    img.Metadata.IccProfile = new(ICCProfileProvider.ICCProfile[ColorProfile]);
                }

                switch (ExportFormat)
                {
                    case 0:
                    {
                        JpegEncodingColor c = psd.Header.ColorMode switch
                        {
                            ColorMode.Grayscale => JpegEncodingColor.Luminance,
                            _ => JpegEncodingColor.YCbCrRatio444
                        };
                        img.SaveAsJpeg(Path.Combine(ExportPath, $"{fileName}.jpg"), new JpegEncoder() { Quality=JPGExportQuality, ColorType=c });
                        break;
                    }
                    case 1:
                    {
                        PngColorType c = psd.Header.ColorMode switch
                        {
                            ColorMode.Grayscale => PngColorType.Grayscale,
                            _ => PngColorType.Rgb
                        };
                        img.SaveAsPng(Path.Combine(ExportPath, $"{fileName}.png"), new PngEncoder() { CompressionLevel=(PngCompressionLevel)PngCompressLevel, ColorType=c });
                        break;
                    }
                    default:
                        throw new NotSupportedException("Unknown export format.");
                }
                p++;
            }
            DialogResult = token.IsCancellationRequested ? DialogResult.Cancel : DialogResult.OK;
        }
    }
}
