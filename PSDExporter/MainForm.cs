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
                if(_config.AppSettings.Settings["ExportFormat"].Value == "JPG")
                {
                    radioButton1.Checked = true;
                    radioButton2.Checked = false;
                }
                else
                {
                    radioButton1.Checked = false;
                    radioButton2.Checked = true;
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
        }

        private bool ValidateSettings()
        {
            if(exportPath.Text.Length == 0 || !Path.Exists(exportPath.Text))
            {
                toolStripStatusLabel1.ForeColor = Color.DarkRed;
                toolStripStatusLabel1.Text = "导出路径无效！";
                //MessageBox.Show(, "导出");
                return false;
            }

            if(filesList.Items.Count == 0)
            {
                toolStripStatusLabel1.ForeColor = Color.DarkRed;
                toolStripStatusLabel1.Text = "待导出列表为空！";
                //MessageBox.Show(, "导出");
                return false;
            }

            if (_config.AppSettings.Settings.Count > 0)
            {
                _config.AppSettings.Settings["ExportPath"].Value = exportPath.Text;
                _config.AppSettings.Settings["ExportFormat"].Value = radioButton1.Checked ? "JPG" : "PNG";
                _config.AppSettings.Settings["JpgExportQuality"].Value = $"{jpgExportQuality.Value}";
                _config.AppSettings.Settings["PngCompressLevel"].Value = $"{pngCompressLevel.Value}";
                _config.AppSettings.Settings["ColorProfile"].Value = $"{comboBox1.SelectedIndex}";
                _config.AppSettings.Settings["CopyRightStr"].Value = copyrightTextBox.Text;
                _config.AppSettings.Settings["ArtistStr"].Value = artistTextBox.Text;
                _config.AppSettings.Settings["DescriptionStr"].Value = descriptionTextBox.Text;
                _config.AppSettings.Settings["SoftwareStr"].Value = softwareTextBox.Text;
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
                modalForm.ExportFormat = radioButton1.Checked ? 0 : 1;
                modalForm.JPGExportQuality = Convert.ToInt32(jpgExportQuality.Value);
                modalForm.PngCompressLevel = Convert.ToInt32(pngCompressLevel.Value);
                modalForm.CopyRightStr = copyrightTextBox.Text;
                modalForm.SoftwareStr = softwareTextBox.Text;
                modalForm.ArtistStr = artistTextBox.Text;
                modalForm.DescriptionStr = descriptionTextBox.Text;
                modalForm.ColorProfile = comboBox1.SelectedIndex;

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
                catch(Exception ex)
                {
                    toolStripStatusLabel1.ForeColor = Color.DarkRed;
                    toolStripStatusLabel1.Text = $"导出时出现错误：\n{ex.Message}";
                    //MessageBox.Show(, "导出", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
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
                    filesList.Items.Add(file);
            }
            ResetStatusBar();
        }

        private void ExportPathDragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            if(files.Length > 0)
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

        private void UpdatePanelState()
        {
            if (radioButton1.Checked == true)
            {
                jpgExportSettingsPanel.Enabled = true;
                pngExportSettingsPanel.Enabled = false;
            }
            else
            {
                jpgExportSettingsPanel.Enabled = false;
                pngExportSettingsPanel.Enabled = true;
            }
            ResetStatusBar();
        }

        private void RadioButtonCheckedChanged(object sender, EventArgs e)
        {
            UpdatePanelState();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                exportPath.Text = folderBrowserDialog1.SelectedPath;
            }
            ResetStatusBar();
        }

    }
}
