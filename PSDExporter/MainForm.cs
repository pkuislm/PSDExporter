using System;
using System.Configuration;
using System.Windows.Forms;

namespace PSDExporter
{
    public partial class MainForm : Form
    {
        private readonly Configuration _config;
        public MainForm()
        {
            _config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            InitializeComponent();
            ReadSettings();
        }

        private void ResetStatusBar()
        {
            toolStripStatusLabel1.ForeColor = Color.Black;
            toolStripStatusLabel1.Text = "就绪。";
        }

        private void ReadSettings()
        {
            if (_config.AppSettings.Settings.Count == 0)
                return;

            if (_config.AppSettings.Settings["ExportPath"].Value != "")
                exportPath.Text = _config.AppSettings.Settings["ExportPath"].Value;
            if (_config.AppSettings.Settings["ExportFormat"].Value != "")
            {
                switch (_config.AppSettings.Settings["ExportFormat"].Value)
                {
                    case "PNG":
                        radioButton1.Checked = false;
                        radioButton2.Checked = true;
                        radioButton3.Checked = false;
                        exportSettingsPages.SelectTab(1);
                        break;
                    case "WEBP":
                        radioButton1.Checked = false;
                        radioButton2.Checked = false;
                        radioButton3.Checked = true;
                        exportSettingsPages.SelectTab(2);
                        break;
                    default:
                        radioButton1.Checked = true;
                        radioButton2.Checked = false;
                        radioButton3.Checked = false;
                        exportSettingsPages.SelectTab(0);
                        break;
                }
            }
            if (_config.AppSettings.Settings["JpgExportQuality"].Value != "")
                jpgExportQuality.Value = Convert.ToInt32(_config.AppSettings.Settings["JpgExportQuality"].Value);
            if (_config.AppSettings.Settings["PngCompressLevel"].Value != "")
                pngCompressLevel.Value = Convert.ToInt32(_config.AppSettings.Settings["PngCompressLevel"].Value);
            if (_config.AppSettings.Settings["ColorProfile"].Value != "")
                comboBox1.SelectedIndex = Convert.ToInt32(_config.AppSettings.Settings["ColorProfile"].Value);

            if (_config.AppSettings.Settings["CopyRightStr"].Value != "")
                copyrightTextBox.Text = _config.AppSettings.Settings["CopyRightStr"].Value;
            if (_config.AppSettings.Settings["SoftwareStr"].Value != "")
                softwareTextBox.Text = _config.AppSettings.Settings["SoftwareStr"].Value;
            if (_config.AppSettings.Settings["ArtistStr"].Value != "")
                artistTextBox.Text = _config.AppSettings.Settings["ArtistStr"].Value;
            if (_config.AppSettings.Settings["DescriptionStr"].Value != "")
                descriptionTextBox.Text = _config.AppSettings.Settings["DescriptionStr"].Value;

            if (_config.AppSettings.Settings["WebpNearLossless"].Value == "1")
                checkBox3.Checked = true;
            if (_config.AppSettings.Settings["WebpExportMode"].Value == "1")
                radioButton5.PerformClick();
            if (_config.AppSettings.Settings["WebpNearLosslessQuality"].Value != "")
                nearLosslessQuality.Value = Convert.ToInt32(_config.AppSettings.Settings["WebpNearLosslessQuality"].Value);
            if (_config.AppSettings.Settings["WebpEntropyPasses"].Value != "")
                numericUpDown1.Value = Convert.ToInt32(_config.AppSettings.Settings["WebpEntropyPasses"].Value);
            if (_config.AppSettings.Settings["WebpQuality"].Value != "")
                numericUpDown3.Value = Convert.ToInt32(_config.AppSettings.Settings["WebpQuality"].Value);
            if (_config.AppSettings.Settings["WebpEncodingMethod"].Value != "")
                comboBox2.SelectedIndex = Convert.ToInt32(_config.AppSettings.Settings["WebpEncodingMethod"].Value);
            nearLosslessQuality.Enabled = radioButton4.Checked;
        }

        private bool ValidateSettings()
        {
            if (exportPath.Text.Length == 0)
            {
                toolStripStatusLabel1.ForeColor = Color.DarkRed;
                toolStripStatusLabel1.Text = "导出路径无效！";
                //MessageBox.Show(, "导出");
                return false;
            }

            if (!Directory.Exists(exportPath.Text))
            {
                Directory.CreateDirectory(exportPath.Text);
            }

            if (filesList.Items.Count == 0)
            {
                toolStripStatusLabel1.ForeColor = Color.DarkRed;
                toolStripStatusLabel1.Text = "待导出列表为空！";
                //MessageBox.Show(, "导出");
                return false;
            }

            if (_config.AppSettings.Settings.Count > 0)
            {
                _config.AppSettings.Settings["ExportPath"].Value = exportPath.Text;
                _config.AppSettings.Settings["ExportFormat"].Value = radioButton1.Checked ? "JPG" : radioButton2.Checked ? "PNG" : "WEBP";
                _config.AppSettings.Settings["JpgExportQuality"].Value = $"{jpgExportQuality.Value}";
                _config.AppSettings.Settings["PngCompressLevel"].Value = $"{pngCompressLevel.Value}";
                _config.AppSettings.Settings["ColorProfile"].Value = $"{comboBox1.SelectedIndex}";
                _config.AppSettings.Settings["CopyRightStr"].Value = copyrightTextBox.Text;
                _config.AppSettings.Settings["ArtistStr"].Value = artistTextBox.Text;
                _config.AppSettings.Settings["DescriptionStr"].Value = descriptionTextBox.Text;
                _config.AppSettings.Settings["SoftwareStr"].Value = softwareTextBox.Text;

                _config.AppSettings.Settings["WebpNearLossless"].Value = checkBox3.Checked ? "1" : "0";
                _config.AppSettings.Settings["WebpExportMode"].Value = radioButton5.Checked ? "1" : "0";
                _config.AppSettings.Settings["WebpNearLosslessQuality"].Value = $"{nearLosslessQuality.Value}";
                _config.AppSettings.Settings["WebpEntropyPasses"].Value = $"{numericUpDown1.Value}";
                _config.AppSettings.Settings["WebpQuality"].Value = $"{numericUpDown3.Value}";
                _config.AppSettings.Settings["WebpEncodingMethod"].Value = $"{comboBox2.SelectedIndex}";

                _config.Save();
            }
            return true;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            ResetStatusBar();
            if (!ValidateSettings())
                return;

            using (ExportProgress modalForm = new())
            {
                modalForm.ExportPath = exportPath.Text;
                modalForm.ExportFormat = radioButton1.Checked ? 0 : radioButton2.Checked ? 1 : 2;
                modalForm.JPGExportQuality = Convert.ToInt32(jpgExportQuality.Value);
                modalForm.PngCompressLevel = Convert.ToInt32(pngCompressLevel.Value);
                modalForm.CopyRightStr = copyrightTextBox.Text;
                modalForm.SoftwareStr = softwareTextBox.Text;
                modalForm.ArtistStr = artistTextBox.Text;
                modalForm.DescriptionStr = descriptionTextBox.Text;
                modalForm.ColorProfile = comboBox1.SelectedIndex;
                modalForm.GrayMode = checkBox2.Checked;

                //true --> lossless
                modalForm.WebpExportMode = radioButton5.Checked;
                modalForm.WebpNearLossless = checkBox3.Checked;
                modalForm.WebpNearLosslessQuality = Convert.ToInt32(nearLosslessQuality.Value);
                modalForm.WebpEntropyPasses = Convert.ToInt32(numericUpDown1.Value);
                modalForm.WebpQuality = Convert.ToInt32(numericUpDown3.Value);
                modalForm.WebpEncodingMethod = comboBox2.SelectedIndex;

                foreach (var i in filesList.Items)
                {
                    if (i is string path)
                    {
                        modalForm.PSDPath.Add(path);
                    }
                }

                try
                {
                    DialogResult result = modalForm.ShowDialog(this);
                    if (result == DialogResult.Cancel)
                    {
                        toolStripStatusLabel1.ForeColor = Color.OrangeRed;
                        toolStripStatusLabel1.Text = "操作被取消。";
                        //MessageBox.Show("", "导出", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    else if (result == DialogResult.OK)
                    {
                        toolStripStatusLabel1.ForeColor = Color.DarkGreen;
                        toolStripStatusLabel1.Text = "导出完成。";
                        //MessageBox.Show("导出完成。", "导出", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    toolStripStatusLabel1.ForeColor = Color.DarkRed;
                    toolStripStatusLabel1.Text = $"导出时出现错误：\n{ex.Message}";
                    //MessageBox.Show(, "导出", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            GC.WaitForPendingFinalizers();
            GC.Collect();
        }

        private void FilesListDragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop, false) == true)
            {
                e.Effect = DragDropEffects.All;
            }
        }

        private void FilesListDragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            foreach (string file in files)
            {
                if (!filesList.Items.Contains(file))
                {
                    if(filesList.Items.Count == 0)
                    {
                        //Set export path
                        exportPath.Text = Path.Combine(Path.GetDirectoryName(file) ?? Directory.GetCurrentDirectory(), "output");
                    }
                    filesList.Items.Add(file);
                }
            }
            ResetStatusBar();
        }

        private void ExportPathDragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            if (files.Length > 0)
            {
                if ((File.GetAttributes(files[0]) & FileAttributes.Directory) == FileAttributes.Directory)
                {
                    exportPath.Text = files[0];
                }
            }
            ResetStatusBar();
        }

        private void ClearFileListButtonClick(object sender, EventArgs e)
        {
            ResetStatusBar();
            filesList.Items.Clear();
        }

        private void DeleteSelItemInListButtonClick(object sender, EventArgs e)
        {
            List<object> selected = [];
            foreach (var i in filesList.SelectedItems)
            {
                selected.Add(i);
            }

            foreach (var i in selected)
            {
                filesList.Items.Remove(i);
            }
            ResetStatusBar();
        }

        private void ExportFormatChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                exportSettingsPages.SelectTab(0);
            }
            else if (radioButton2.Checked == true)
            {
                exportSettingsPages.SelectTab(1);
            }
            else
            {
                exportSettingsPages.SelectTab(2);
            }
            ResetStatusBar();
        }

        private void WebPExportModeChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked == true)
            {
                checkBox3.Enabled = true;
                nearLosslessQuality.Enabled = checkBox3.Checked;
            }
            else
            {
                checkBox3.Enabled = false;
                nearLosslessQuality.Enabled = false;
            }
            ResetStatusBar();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                exportPath.Text = folderBrowserDialog1.SelectedPath;
            }
            ResetStatusBar();
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            nearLosslessQuality.Enabled = checkBox3.Checked;
        }
    }
}
