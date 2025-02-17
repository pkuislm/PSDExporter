namespace PSDExporter
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            fileInputBox = new GroupBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel3 = new TableLayoutPanel();
            deleteSelItemInListButton = new Button();
            clearFileListButton = new Button();
            filesList = new ListBox();
            exportSettingBox = new GroupBox();
            flowLayout = new FlowLayoutPanel();
            exportDetailsPanel = new TableLayoutPanel();
            label2 = new Label();
            label3 = new Label();
            flowLayoutPanel3 = new FlowLayoutPanel();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
            checkBox2 = new CheckBox();
            exportPath = new TextBox();
            button4 = new Button();
            exportSettingsPages = new TabControl();
            jpgSettingsTab = new TabPage();
            jpgExportSettingsPanel = new GroupBox();
            tableLayoutPanel8 = new TableLayoutPanel();
            jpgExportQuality = new NumericUpDown();
            label5 = new Label();
            pngSettingsTab = new TabPage();
            pngExportSettingsPanel = new GroupBox();
            tableLayoutPanel7 = new TableLayoutPanel();
            label4 = new Label();
            pngCompressLevel = new NumericUpDown();
            webPSettingsTab = new TabPage();
            webPExportSettingsPanel = new GroupBox();
            tableLayoutPanel12 = new TableLayoutPanel();
            label17 = new Label();
            label18 = new Label();
            label19 = new Label();
            comboBox2 = new ComboBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            radioButton5 = new RadioButton();
            radioButton4 = new RadioButton();
            checkBox3 = new CheckBox();
            numericUpDown1 = new NumericUpDown();
            label20 = new Label();
            nearLosslessQuality = new NumericUpDown();
            numericUpDown3 = new NumericUpDown();
            label21 = new Label();
            exportFileNameSettingsPanel = new GroupBox();
            checkBox1 = new CheckBox();
            textBox4 = new TextBox();
            label16 = new Label();
            textBox3 = new TextBox();
            label15 = new Label();
            textBox2 = new TextBox();
            label14 = new Label();
            label13 = new Label();
            metadataBox = new GroupBox();
            tableLayoutPanel5 = new TableLayoutPanel();
            label6 = new Label();
            label7 = new Label();
            descriptionTextBox = new RichTextBox();
            copyrightTextBox = new RichTextBox();
            label10 = new Label();
            label8 = new Label();
            artistTextBox = new RichTextBox();
            softwareTextBox = new RichTextBox();
            label9 = new Label();
            comboBox1 = new ComboBox();
            folderBrowserDialog1 = new FolderBrowserDialog();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            tabControl1 = new TabControl();
            PSDExportPage = new TabPage();
            tabPage2 = new TabPage();
            tableLayoutPanel9 = new TableLayoutPanel();
            tableLayoutPanel10 = new TableLayoutPanel();
            label1 = new Label();
            textBox1 = new TextBox();
            button2 = new Button();
            groupBox3 = new GroupBox();
            label11 = new Label();
            groupBox4 = new GroupBox();
            label12 = new Label();
            tableLayoutPanel1.SuspendLayout();
            fileInputBox.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            exportSettingBox.SuspendLayout();
            flowLayout.SuspendLayout();
            exportDetailsPanel.SuspendLayout();
            flowLayoutPanel3.SuspendLayout();
            exportSettingsPages.SuspendLayout();
            jpgSettingsTab.SuspendLayout();
            jpgExportSettingsPanel.SuspendLayout();
            tableLayoutPanel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)jpgExportQuality).BeginInit();
            pngSettingsTab.SuspendLayout();
            pngExportSettingsPanel.SuspendLayout();
            tableLayoutPanel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pngCompressLevel).BeginInit();
            webPSettingsTab.SuspendLayout();
            webPExportSettingsPanel.SuspendLayout();
            tableLayoutPanel12.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nearLosslessQuality).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).BeginInit();
            exportFileNameSettingsPanel.SuspendLayout();
            metadataBox.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            statusStrip1.SuspendLayout();
            tabControl1.SuspendLayout();
            PSDExportPage.SuspendLayout();
            tabPage2.SuspendLayout();
            tableLayoutPanel9.SuspendLayout();
            tableLayoutPanel10.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.AutoSize = true;
            button1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button1.Dock = DockStyle.Bottom;
            button1.Location = new Point(3, 461);
            button1.Name = "button1";
            button1.Size = new Size(422, 27);
            button1.TabIndex = 0;
            button1.Text = "开导";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel1.ColumnCount = 8;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel1.Controls.Add(fileInputBox, 0, 0);
            tableLayoutPanel1.Controls.Add(exportSettingBox, 0, 1);
            tableLayoutPanel1.Controls.Add(metadataBox, 4, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(3, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.Size = new Size(880, 753);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // fileInputBox
            // 
            fileInputBox.AutoSize = true;
            fileInputBox.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel1.SetColumnSpan(fileInputBox, 8);
            fileInputBox.Controls.Add(tableLayoutPanel2);
            fileInputBox.Dock = DockStyle.Fill;
            fileInputBox.Location = new Point(3, 3);
            fileInputBox.Name = "fileInputBox";
            fileInputBox.Size = new Size(874, 229);
            fileInputBox.TabIndex = 5;
            fileInputBox.TabStop = false;
            fileInputBox.Text = "拖拽包含.psd的文件夹或者.psd文件至下方列表中";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.AutoSize = true;
            tableLayoutPanel2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(tableLayoutPanel3, 0, 1);
            tableLayoutPanel2.Controls.Add(filesList, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Top;
            tableLayoutPanel2.Location = new Point(3, 19);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.Size = new Size(868, 207);
            tableLayoutPanel2.TabIndex = 2;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.AutoSize = true;
            tableLayoutPanel3.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel2.SetColumnSpan(tableLayoutPanel3, 2);
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(deleteSelItemInListButton, 0, 0);
            tableLayoutPanel3.Controls.Add(clearFileListButton, 1, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(0, 180);
            tableLayoutPanel3.Margin = new Padding(0);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle());
            tableLayoutPanel3.Size = new Size(868, 27);
            tableLayoutPanel3.TabIndex = 0;
            // 
            // deleteSelItemInListButton
            // 
            deleteSelItemInListButton.AutoSize = true;
            deleteSelItemInListButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            deleteSelItemInListButton.Dock = DockStyle.Fill;
            deleteSelItemInListButton.Location = new Point(0, 0);
            deleteSelItemInListButton.Margin = new Padding(0);
            deleteSelItemInListButton.Name = "deleteSelItemInListButton";
            deleteSelItemInListButton.Size = new Size(434, 27);
            deleteSelItemInListButton.TabIndex = 0;
            deleteSelItemInListButton.Text = "删除选定";
            deleteSelItemInListButton.UseVisualStyleBackColor = true;
            deleteSelItemInListButton.Click += DeleteSelItemInListButtonClick;
            // 
            // clearFileListButton
            // 
            clearFileListButton.AutoSize = true;
            clearFileListButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            clearFileListButton.Dock = DockStyle.Fill;
            clearFileListButton.Location = new Point(434, 0);
            clearFileListButton.Margin = new Padding(0);
            clearFileListButton.Name = "clearFileListButton";
            clearFileListButton.Size = new Size(434, 27);
            clearFileListButton.TabIndex = 1;
            clearFileListButton.Text = "清空";
            clearFileListButton.UseVisualStyleBackColor = true;
            clearFileListButton.Click += ClearFileListButtonClick;
            // 
            // filesList
            // 
            filesList.AllowDrop = true;
            tableLayoutPanel2.SetColumnSpan(filesList, 2);
            filesList.Dock = DockStyle.Top;
            filesList.FormattingEnabled = true;
            filesList.HorizontalScrollbar = true;
            filesList.ItemHeight = 17;
            filesList.Location = new Point(3, 3);
            filesList.Name = "filesList";
            filesList.SelectionMode = SelectionMode.MultiExtended;
            filesList.Size = new Size(862, 174);
            filesList.TabIndex = 1;
            filesList.DragDrop += FilesListDragDrop;
            filesList.DragEnter += FilesListDragEnter;
            // 
            // exportSettingBox
            // 
            exportSettingBox.AutoSize = true;
            exportSettingBox.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel1.SetColumnSpan(exportSettingBox, 4);
            exportSettingBox.Controls.Add(flowLayout);
            exportSettingBox.Dock = DockStyle.Fill;
            exportSettingBox.Location = new Point(3, 238);
            exportSettingBox.Name = "exportSettingBox";
            exportSettingBox.Size = new Size(434, 513);
            exportSettingBox.TabIndex = 3;
            exportSettingBox.TabStop = false;
            exportSettingBox.Text = "导出设定";
            // 
            // flowLayout
            // 
            flowLayout.AutoSize = true;
            flowLayout.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flowLayout.Controls.Add(exportDetailsPanel);
            flowLayout.Controls.Add(exportSettingsPages);
            flowLayout.Controls.Add(exportFileNameSettingsPanel);
            flowLayout.Dock = DockStyle.Left;
            flowLayout.FlowDirection = FlowDirection.TopDown;
            flowLayout.Location = new Point(3, 19);
            flowLayout.Name = "flowLayout";
            flowLayout.Size = new Size(429, 491);
            flowLayout.TabIndex = 2;
            // 
            // exportDetailsPanel
            // 
            exportDetailsPanel.AutoSize = true;
            exportDetailsPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            exportDetailsPanel.ColumnCount = 3;
            exportDetailsPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            exportDetailsPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            exportDetailsPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            exportDetailsPanel.Controls.Add(label2, 0, 0);
            exportDetailsPanel.Controls.Add(label3, 0, 1);
            exportDetailsPanel.Controls.Add(flowLayoutPanel3, 1, 0);
            exportDetailsPanel.Controls.Add(exportPath, 1, 1);
            exportDetailsPanel.Controls.Add(button4, 2, 1);
            exportDetailsPanel.Dock = DockStyle.Fill;
            exportDetailsPanel.Location = new Point(3, 3);
            exportDetailsPanel.Name = "exportDetailsPanel";
            exportDetailsPanel.RowCount = 2;
            exportDetailsPanel.RowStyles.Add(new RowStyle());
            exportDetailsPanel.RowStyles.Add(new RowStyle());
            exportDetailsPanel.Size = new Size(423, 62);
            exportDetailsPanel.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Location = new Point(3, 3);
            label2.Margin = new Padding(3);
            label2.Name = "label2";
            label2.Size = new Size(78, 27);
            label2.TabIndex = 1;
            label2.Text = "导出格式：";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Fill;
            label3.Location = new Point(3, 36);
            label3.Margin = new Padding(3);
            label3.Name = "label3";
            label3.Size = new Size(78, 23);
            label3.TabIndex = 2;
            label3.Text = "导出路径：";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanel3
            // 
            flowLayoutPanel3.AutoSize = true;
            flowLayoutPanel3.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            exportDetailsPanel.SetColumnSpan(flowLayoutPanel3, 2);
            flowLayoutPanel3.Controls.Add(radioButton1);
            flowLayoutPanel3.Controls.Add(radioButton2);
            flowLayoutPanel3.Controls.Add(radioButton3);
            flowLayoutPanel3.Controls.Add(checkBox2);
            flowLayoutPanel3.Dock = DockStyle.Fill;
            flowLayoutPanel3.Location = new Point(87, 3);
            flowLayoutPanel3.Name = "flowLayoutPanel3";
            flowLayoutPanel3.Size = new Size(333, 27);
            flowLayoutPanel3.TabIndex = 3;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Checked = true;
            radioButton1.Location = new Point(3, 3);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(47, 21);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "JPG";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.Click += ExportFormatChanged;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(56, 3);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(52, 21);
            radioButton2.TabIndex = 1;
            radioButton2.Text = "PNG";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.Click += ExportFormatChanged;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(114, 3);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(57, 21);
            radioButton3.TabIndex = 3;
            radioButton3.TabStop = true;
            radioButton3.Text = "webP";
            radioButton3.UseVisualStyleBackColor = true;
            radioButton3.Click += ExportFormatChanged;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(177, 3);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(99, 21);
            checkBox2.TabIndex = 2;
            checkBox2.Text = "强制灰度输出";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // exportPath
            // 
            exportPath.AllowDrop = true;
            exportPath.Dock = DockStyle.Fill;
            exportPath.Location = new Point(87, 36);
            exportPath.Name = "exportPath";
            exportPath.Size = new Size(247, 23);
            exportPath.TabIndex = 4;
            exportPath.DragDrop += ExportPathDragDrop;
            exportPath.DragEnter += FilesListDragEnter;
            // 
            // button4
            // 
            button4.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button4.Location = new Point(340, 36);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 5;
            button4.Text = "浏览";
            button4.UseVisualStyleBackColor = true;
            // 
            // exportSettingsPages
            // 
            exportSettingsPages.Appearance = TabAppearance.Buttons;
            exportSettingsPages.Controls.Add(jpgSettingsTab);
            exportSettingsPages.Controls.Add(pngSettingsTab);
            exportSettingsPages.Controls.Add(webPSettingsTab);
            exportSettingsPages.ItemSize = new Size(0, 1);
            exportSettingsPages.Location = new Point(0, 68);
            exportSettingsPages.Margin = new Padding(0);
            exportSettingsPages.Name = "exportSettingsPages";
            exportSettingsPages.Padding = new Point(0, 0);
            exportSettingsPages.SelectedIndex = 0;
            exportSettingsPages.Size = new Size(428, 185);
            exportSettingsPages.SizeMode = TabSizeMode.Fixed;
            exportSettingsPages.TabIndex = 9;
            // 
            // jpgSettingsTab
            // 
            jpgSettingsTab.BackColor = SystemColors.ControlLightLight;
            jpgSettingsTab.Controls.Add(jpgExportSettingsPanel);
            jpgSettingsTab.Location = new Point(4, 5);
            jpgSettingsTab.Name = "jpgSettingsTab";
            jpgSettingsTab.Padding = new Padding(3);
            jpgSettingsTab.Size = new Size(420, 176);
            jpgSettingsTab.TabIndex = 0;
            // 
            // jpgExportSettingsPanel
            // 
            jpgExportSettingsPanel.AutoSize = true;
            jpgExportSettingsPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            jpgExportSettingsPanel.BackColor = SystemColors.ControlLightLight;
            jpgExportSettingsPanel.Controls.Add(tableLayoutPanel8);
            jpgExportSettingsPanel.Dock = DockStyle.Top;
            jpgExportSettingsPanel.Location = new Point(3, 3);
            jpgExportSettingsPanel.Name = "jpgExportSettingsPanel";
            jpgExportSettingsPanel.Size = new Size(414, 51);
            jpgExportSettingsPanel.TabIndex = 2;
            jpgExportSettingsPanel.TabStop = false;
            jpgExportSettingsPanel.Text = "JPG 导出设定";
            // 
            // tableLayoutPanel8
            // 
            tableLayoutPanel8.AutoSize = true;
            tableLayoutPanel8.ColumnCount = 2;
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel8.Controls.Add(jpgExportQuality, 1, 0);
            tableLayoutPanel8.Controls.Add(label5, 0, 0);
            tableLayoutPanel8.Dock = DockStyle.Fill;
            tableLayoutPanel8.Location = new Point(3, 19);
            tableLayoutPanel8.Name = "tableLayoutPanel8";
            tableLayoutPanel8.RowCount = 1;
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel8.Size = new Size(408, 29);
            tableLayoutPanel8.TabIndex = 0;
            // 
            // jpgExportQuality
            // 
            jpgExportQuality.Anchor = AnchorStyles.Right;
            jpgExportQuality.Location = new Point(285, 3);
            jpgExportQuality.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            jpgExportQuality.Name = "jpgExportQuality";
            jpgExportQuality.Size = new Size(120, 23);
            jpgExportQuality.TabIndex = 1;
            jpgExportQuality.Value = new decimal(new int[] { 100, 0, 0, 0 });
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Left;
            label5.AutoSize = true;
            label5.Location = new Point(3, 6);
            label5.Margin = new Padding(3);
            label5.Name = "label5";
            label5.Size = new Size(238, 17);
            label5.TabIndex = 0;
            label5.Text = "JPG 质量设定(0=最小体积, 100=最好质量)";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pngSettingsTab
            // 
            pngSettingsTab.BackColor = SystemColors.ControlLightLight;
            pngSettingsTab.Controls.Add(pngExportSettingsPanel);
            pngSettingsTab.Location = new Point(4, 5);
            pngSettingsTab.Name = "pngSettingsTab";
            pngSettingsTab.Padding = new Padding(3);
            pngSettingsTab.Size = new Size(420, 176);
            pngSettingsTab.TabIndex = 1;
            // 
            // pngExportSettingsPanel
            // 
            pngExportSettingsPanel.AutoSize = true;
            pngExportSettingsPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            pngExportSettingsPanel.Controls.Add(tableLayoutPanel7);
            pngExportSettingsPanel.Dock = DockStyle.Top;
            pngExportSettingsPanel.Location = new Point(3, 3);
            pngExportSettingsPanel.Name = "pngExportSettingsPanel";
            pngExportSettingsPanel.Size = new Size(414, 51);
            pngExportSettingsPanel.TabIndex = 3;
            pngExportSettingsPanel.TabStop = false;
            pngExportSettingsPanel.Text = "PNG 导出设定";
            // 
            // tableLayoutPanel7
            // 
            tableLayoutPanel7.AutoSize = true;
            tableLayoutPanel7.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel7.ColumnCount = 2;
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel7.Controls.Add(label4, 0, 0);
            tableLayoutPanel7.Controls.Add(pngCompressLevel, 1, 0);
            tableLayoutPanel7.Dock = DockStyle.Top;
            tableLayoutPanel7.Location = new Point(3, 19);
            tableLayoutPanel7.Name = "tableLayoutPanel7";
            tableLayoutPanel7.RowCount = 1;
            tableLayoutPanel7.RowStyles.Add(new RowStyle());
            tableLayoutPanel7.Size = new Size(408, 29);
            tableLayoutPanel7.TabIndex = 1;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Left;
            label4.AutoSize = true;
            label4.Location = new Point(3, 6);
            label4.Margin = new Padding(3);
            label4.Name = "label4";
            label4.Size = new Size(229, 17);
            label4.TabIndex = 0;
            label4.Text = "PNG 压缩等级(0=最快速度, 9=最小体积)";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pngCompressLevel
            // 
            pngCompressLevel.Anchor = AnchorStyles.Right;
            pngCompressLevel.Location = new Point(285, 3);
            pngCompressLevel.Maximum = new decimal(new int[] { 9, 0, 0, 0 });
            pngCompressLevel.Name = "pngCompressLevel";
            pngCompressLevel.Size = new Size(120, 23);
            pngCompressLevel.TabIndex = 1;
            pngCompressLevel.Value = new decimal(new int[] { 9, 0, 0, 0 });
            // 
            // webPSettingsTab
            // 
            webPSettingsTab.BackColor = SystemColors.ControlLightLight;
            webPSettingsTab.Controls.Add(webPExportSettingsPanel);
            webPSettingsTab.Location = new Point(4, 5);
            webPSettingsTab.Name = "webPSettingsTab";
            webPSettingsTab.Padding = new Padding(3);
            webPSettingsTab.Size = new Size(420, 176);
            webPSettingsTab.TabIndex = 2;
            webPSettingsTab.Text = "tabPage5";
            // 
            // webPExportSettingsPanel
            // 
            webPExportSettingsPanel.AutoSize = true;
            webPExportSettingsPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            webPExportSettingsPanel.Controls.Add(tableLayoutPanel12);
            webPExportSettingsPanel.Dock = DockStyle.Top;
            webPExportSettingsPanel.ImeMode = ImeMode.NoControl;
            webPExportSettingsPanel.Location = new Point(3, 3);
            webPExportSettingsPanel.Name = "webPExportSettingsPanel";
            webPExportSettingsPanel.Size = new Size(414, 173);
            webPExportSettingsPanel.TabIndex = 8;
            webPExportSettingsPanel.TabStop = false;
            webPExportSettingsPanel.Text = "webP 导出设定";
            // 
            // tableLayoutPanel12
            // 
            tableLayoutPanel12.AutoSize = true;
            tableLayoutPanel12.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel12.ColumnCount = 2;
            tableLayoutPanel12.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel12.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel12.Controls.Add(label17, 0, 1);
            tableLayoutPanel12.Controls.Add(label18, 0, 2);
            tableLayoutPanel12.Controls.Add(label19, 0, 3);
            tableLayoutPanel12.Controls.Add(comboBox2, 1, 2);
            tableLayoutPanel12.Controls.Add(flowLayoutPanel1, 1, 0);
            tableLayoutPanel12.Controls.Add(numericUpDown1, 1, 1);
            tableLayoutPanel12.Controls.Add(label20, 0, 4);
            tableLayoutPanel12.Controls.Add(nearLosslessQuality, 1, 3);
            tableLayoutPanel12.Controls.Add(numericUpDown3, 1, 4);
            tableLayoutPanel12.Controls.Add(label21, 0, 0);
            tableLayoutPanel12.Dock = DockStyle.Top;
            tableLayoutPanel12.Location = new Point(3, 19);
            tableLayoutPanel12.Name = "tableLayoutPanel12";
            tableLayoutPanel12.RowCount = 5;
            tableLayoutPanel12.RowStyles.Add(new RowStyle());
            tableLayoutPanel12.RowStyles.Add(new RowStyle());
            tableLayoutPanel12.RowStyles.Add(new RowStyle());
            tableLayoutPanel12.RowStyles.Add(new RowStyle());
            tableLayoutPanel12.RowStyles.Add(new RowStyle());
            tableLayoutPanel12.Size = new Size(408, 151);
            tableLayoutPanel12.TabIndex = 0;
            // 
            // label17
            // 
            label17.Anchor = AnchorStyles.Left;
            label17.AutoSize = true;
            label17.Location = new Point(3, 39);
            label17.Margin = new Padding(3);
            label17.Name = "label17";
            label17.Size = new Size(92, 17);
            label17.TabIndex = 3;
            label17.Text = "EntropyPasses";
            // 
            // label18
            // 
            label18.Anchor = AnchorStyles.Left;
            label18.AutoSize = true;
            label18.Location = new Point(3, 69);
            label18.Margin = new Padding(3);
            label18.Name = "label18";
            label18.Size = new Size(108, 17);
            label18.TabIndex = 4;
            label18.Text = "EncodingMethod";
            // 
            // label19
            // 
            label19.Anchor = AnchorStyles.Left;
            label19.AutoSize = true;
            label19.Location = new Point(3, 99);
            label19.Margin = new Padding(3);
            label19.Name = "label19";
            label19.Size = new Size(125, 17);
            label19.TabIndex = 5;
            label19.Text = "NearLosslessQuality";
            // 
            // comboBox2
            // 
            comboBox2.DisplayMember = "Level4(Default)";
            comboBox2.Dock = DockStyle.Top;
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Fastest", "Level1", "Level2", "Level3", "Level4(Default)", "Level5", "BestQuality" });
            comboBox2.Location = new Point(134, 65);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(271, 25);
            comboBox2.TabIndex = 6;
            comboBox2.ValueMember = "Level4(Default)";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoSize = true;
            flowLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flowLayoutPanel1.Controls.Add(radioButton5);
            flowLayoutPanel1.Controls.Add(radioButton4);
            flowLayoutPanel1.Controls.Add(checkBox3);
            flowLayoutPanel1.Dock = DockStyle.Top;
            flowLayoutPanel1.Location = new Point(134, 3);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(271, 27);
            flowLayoutPanel1.TabIndex = 7;
            // 
            // radioButton5
            // 
            radioButton5.Anchor = AnchorStyles.Left;
            radioButton5.AutoSize = true;
            radioButton5.Checked = true;
            radioButton5.Location = new Point(3, 3);
            radioButton5.Name = "radioButton5";
            radioButton5.Size = new Size(74, 21);
            radioButton5.TabIndex = 2;
            radioButton5.TabStop = true;
            radioButton5.Text = "Lossless";
            radioButton5.UseVisualStyleBackColor = true;
            radioButton5.Click += WebPExportModeChanged;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Dock = DockStyle.Fill;
            radioButton4.Location = new Point(83, 3);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(58, 21);
            radioButton4.TabIndex = 1;
            radioButton4.TabStop = true;
            radioButton4.Text = "Lossy";
            radioButton4.UseVisualStyleBackColor = true;
            radioButton4.Click += WebPExportModeChanged;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Enabled = false;
            checkBox3.Location = new Point(147, 3);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(107, 21);
            checkBox3.TabIndex = 2;
            checkBox3.Text = "NearLossLess";
            checkBox3.UseVisualStyleBackColor = true;
            checkBox3.CheckedChanged += checkBox3_CheckedChanged;
            // 
            // numericUpDown1
            // 
            numericUpDown1.AutoSize = true;
            numericUpDown1.Dock = DockStyle.Top;
            numericUpDown1.Location = new Point(134, 36);
            numericUpDown1.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            numericUpDown1.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(271, 23);
            numericUpDown1.TabIndex = 8;
            numericUpDown1.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Dock = DockStyle.Top;
            label20.Location = new Point(3, 125);
            label20.Margin = new Padding(3);
            label20.Name = "label20";
            label20.RightToLeft = RightToLeft.No;
            label20.Size = new Size(125, 17);
            label20.TabIndex = 9;
            label20.Text = "Quality";
            // 
            // nearLosslessQuality
            // 
            nearLosslessQuality.AutoSize = true;
            nearLosslessQuality.Dock = DockStyle.Top;
            nearLosslessQuality.Enabled = false;
            nearLosslessQuality.Location = new Point(134, 96);
            nearLosslessQuality.Name = "nearLosslessQuality";
            nearLosslessQuality.Size = new Size(271, 23);
            nearLosslessQuality.TabIndex = 10;
            nearLosslessQuality.Value = new decimal(new int[] { 100, 0, 0, 0 });
            // 
            // numericUpDown3
            // 
            numericUpDown3.AutoSize = true;
            numericUpDown3.Dock = DockStyle.Top;
            numericUpDown3.Location = new Point(134, 125);
            numericUpDown3.Name = "numericUpDown3";
            numericUpDown3.Size = new Size(271, 23);
            numericUpDown3.TabIndex = 11;
            numericUpDown3.Value = new decimal(new int[] { 100, 0, 0, 0 });
            // 
            // label21
            // 
            label21.Anchor = AnchorStyles.Left;
            label21.AutoSize = true;
            label21.Location = new Point(3, 8);
            label21.Margin = new Padding(3);
            label21.Name = "label21";
            label21.Size = new Size(43, 17);
            label21.TabIndex = 12;
            label21.Text = "Mode";
            // 
            // exportFileNameSettingsPanel
            // 
            exportFileNameSettingsPanel.AutoSize = true;
            exportFileNameSettingsPanel.Controls.Add(checkBox1);
            exportFileNameSettingsPanel.Controls.Add(textBox4);
            exportFileNameSettingsPanel.Controls.Add(label16);
            exportFileNameSettingsPanel.Controls.Add(textBox3);
            exportFileNameSettingsPanel.Controls.Add(label15);
            exportFileNameSettingsPanel.Controls.Add(textBox2);
            exportFileNameSettingsPanel.Controls.Add(label14);
            exportFileNameSettingsPanel.Controls.Add(label13);
            exportFileNameSettingsPanel.Location = new Point(3, 256);
            exportFileNameSettingsPanel.Name = "exportFileNameSettingsPanel";
            exportFileNameSettingsPanel.Size = new Size(423, 89);
            exportFileNameSettingsPanel.TabIndex = 10;
            exportFileNameSettingsPanel.TabStop = false;
            exportFileNameSettingsPanel.Text = "输出文件名格式";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(6, 22);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(159, 21);
            checkBox1.TabIndex = 7;
            checkBox1.Text = "将导出的图片文件名改为";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(327, 44);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(48, 23);
            textBox4.TabIndex = 5;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(373, 47);
            label16.Name = "label16";
            label16.Size = new Size(44, 17);
            label16.TabIndex = 6;
            label16.Text = "位数字";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(260, 44);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(53, 23);
            textBox3.TabIndex = 3;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(311, 47);
            label15.Name = "label15";
            label15.Size = new Size(20, 17);
            label15.TabIndex = 4;
            label15.Text = "的";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(113, 44);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 0;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(211, 47);
            label14.Name = "label14";
            label14.Size = new Size(53, 17);
            label14.TabIndex = 2;
            label14.Text = "+起始值";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(72, 47);
            label13.Name = "label13";
            label13.Size = new Size(44, 17);
            label13.TabIndex = 1;
            label13.Text = "前缀为";
            // 
            // metadataBox
            // 
            metadataBox.AutoSize = true;
            metadataBox.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel1.SetColumnSpan(metadataBox, 4);
            metadataBox.Controls.Add(tableLayoutPanel5);
            metadataBox.Dock = DockStyle.Fill;
            metadataBox.Location = new Point(443, 238);
            metadataBox.Name = "metadataBox";
            metadataBox.Size = new Size(434, 513);
            metadataBox.TabIndex = 4;
            metadataBox.TabStop = false;
            metadataBox.Text = "元数据";
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.AutoSize = true;
            tableLayoutPanel5.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel5.ColumnCount = 1;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel5.Controls.Add(label6, 0, 0);
            tableLayoutPanel5.Controls.Add(button1, 0, 10);
            tableLayoutPanel5.Controls.Add(label7, 0, 2);
            tableLayoutPanel5.Controls.Add(descriptionTextBox, 0, 9);
            tableLayoutPanel5.Controls.Add(copyrightTextBox, 0, 3);
            tableLayoutPanel5.Controls.Add(label10, 0, 8);
            tableLayoutPanel5.Controls.Add(label8, 0, 4);
            tableLayoutPanel5.Controls.Add(artistTextBox, 0, 7);
            tableLayoutPanel5.Controls.Add(softwareTextBox, 0, 5);
            tableLayoutPanel5.Controls.Add(label9, 0, 6);
            tableLayoutPanel5.Controls.Add(comboBox1, 0, 1);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(3, 19);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 11;
            tableLayoutPanel5.RowStyles.Add(new RowStyle());
            tableLayoutPanel5.RowStyles.Add(new RowStyle());
            tableLayoutPanel5.RowStyles.Add(new RowStyle());
            tableLayoutPanel5.RowStyles.Add(new RowStyle());
            tableLayoutPanel5.RowStyles.Add(new RowStyle());
            tableLayoutPanel5.RowStyles.Add(new RowStyle());
            tableLayoutPanel5.RowStyles.Add(new RowStyle());
            tableLayoutPanel5.RowStyles.Add(new RowStyle());
            tableLayoutPanel5.RowStyles.Add(new RowStyle());
            tableLayoutPanel5.RowStyles.Add(new RowStyle());
            tableLayoutPanel5.RowStyles.Add(new RowStyle());
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel5.Size = new Size(428, 491);
            tableLayoutPanel5.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(3, 3);
            label6.Margin = new Padding(3);
            label6.Name = "label6";
            label6.Size = new Size(80, 17);
            label6.TabIndex = 2;
            label6.Text = "色彩配置文件";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(3, 54);
            label7.Name = "label7";
            label7.Size = new Size(32, 17);
            label7.TabIndex = 3;
            label7.Text = "版权";
            // 
            // descriptionTextBox
            // 
            descriptionTextBox.Dock = DockStyle.Top;
            descriptionTextBox.Location = new Point(3, 377);
            descriptionTextBox.Name = "descriptionTextBox";
            descriptionTextBox.Size = new Size(422, 78);
            descriptionTextBox.TabIndex = 10;
            descriptionTextBox.Text = "";
            // 
            // copyrightTextBox
            // 
            copyrightTextBox.Dock = DockStyle.Top;
            copyrightTextBox.Location = new Point(3, 74);
            copyrightTextBox.Name = "copyrightTextBox";
            copyrightTextBox.Size = new Size(422, 78);
            copyrightTextBox.TabIndex = 4;
            copyrightTextBox.Text = "All work and no play makes Jack a dull Malou";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(3, 357);
            label10.Name = "label10";
            label10.Size = new Size(56, 17);
            label10.TabIndex = 9;
            label10.Text = "图片描述";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(3, 155);
            label8.Name = "label8";
            label8.Size = new Size(32, 17);
            label8.TabIndex = 5;
            label8.Text = "软件";
            // 
            // artistTextBox
            // 
            artistTextBox.Dock = DockStyle.Top;
            artistTextBox.Location = new Point(3, 276);
            artistTextBox.Name = "artistTextBox";
            artistTextBox.Size = new Size(422, 78);
            artistTextBox.TabIndex = 8;
            artistTextBox.Text = "";
            // 
            // softwareTextBox
            // 
            softwareTextBox.Dock = DockStyle.Top;
            softwareTextBox.Location = new Point(3, 175);
            softwareTextBox.Name = "softwareTextBox";
            softwareTextBox.Size = new Size(422, 78);
            softwareTextBox.TabIndex = 6;
            softwareTextBox.Text = "Malou Localization Team (Malou Neverland)";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(3, 256);
            label9.Name = "label9";
            label9.Size = new Size(32, 17);
            label9.TabIndex = 7;
            label9.Text = "作家";
            // 
            // comboBox1
            // 
            comboBox1.Dock = DockStyle.Left;
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Adobe RGB", "sRGB(sGray)", "DCI-P3", "无" });
            comboBox1.Location = new Point(3, 26);
            comboBox1.Name = "comboBox1";
            comboBox1.RightToLeft = RightToLeft.No;
            comboBox1.Size = new Size(422, 25);
            comboBox1.TabIndex = 1;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1 });
            statusStrip1.Location = new Point(0, 789);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(894, 22);
            statusStrip1.SizingGrip = false;
            statusStrip1.TabIndex = 2;
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.ForeColor = SystemColors.ControlText;
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(44, 17);
            toolStripStatusLabel1.Text = "就绪。";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(PSDExportPage);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Margin = new Padding(3, 3, 3, 22);
            tabControl1.MinimumSize = new Size(894, 752);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(894, 789);
            tabControl1.TabIndex = 3;
            // 
            // PSDExportPage
            // 
            PSDExportPage.Controls.Add(tableLayoutPanel1);
            PSDExportPage.Location = new Point(4, 26);
            PSDExportPage.Name = "PSDExportPage";
            PSDExportPage.Padding = new Padding(3);
            PSDExportPage.Size = new Size(886, 759);
            PSDExportPage.TabIndex = 0;
            PSDExportPage.Text = "PSD导出";
            PSDExportPage.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(tableLayoutPanel9);
            tabPage2.Location = new Point(4, 26);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(886, 759);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "图片处理";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel9
            // 
            tableLayoutPanel9.AutoSize = true;
            tableLayoutPanel9.ColumnCount = 1;
            tableLayoutPanel9.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel9.Controls.Add(tableLayoutPanel10, 0, 2);
            tableLayoutPanel9.Controls.Add(groupBox3, 0, 0);
            tableLayoutPanel9.Controls.Add(groupBox4, 0, 1);
            tableLayoutPanel9.Dock = DockStyle.Fill;
            tableLayoutPanel9.Location = new Point(3, 3);
            tableLayoutPanel9.Name = "tableLayoutPanel9";
            tableLayoutPanel9.RowCount = 3;
            tableLayoutPanel9.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel9.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel9.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
            tableLayoutPanel9.Size = new Size(880, 753);
            tableLayoutPanel9.TabIndex = 0;
            // 
            // tableLayoutPanel10
            // 
            tableLayoutPanel10.ColumnCount = 3;
            tableLayoutPanel10.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 9.308511F));
            tableLayoutPanel10.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 90.69149F));
            tableLayoutPanel10.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100F));
            tableLayoutPanel10.Controls.Add(label1, 0, 0);
            tableLayoutPanel10.Controls.Add(textBox1, 1, 0);
            tableLayoutPanel10.Controls.Add(button2, 2, 0);
            tableLayoutPanel10.Dock = DockStyle.Top;
            tableLayoutPanel10.Location = new Point(0, 724);
            tableLayoutPanel10.Margin = new Padding(0);
            tableLayoutPanel10.Name = "tableLayoutPanel10";
            tableLayoutPanel10.RowCount = 1;
            tableLayoutPanel10.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel10.Size = new Size(880, 29);
            tableLayoutPanel10.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 6);
            label1.Margin = new Padding(6);
            label1.Name = "label1";
            label1.Size = new Size(56, 17);
            label1.TabIndex = 0;
            label1.Text = "输出路径";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            textBox1.Dock = DockStyle.Top;
            textBox1.Location = new Point(75, 3);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(701, 23);
            textBox1.TabIndex = 1;
            // 
            // button2
            // 
            button2.Dock = DockStyle.Top;
            button2.Location = new Point(782, 3);
            button2.Name = "button2";
            button2.Size = new Size(95, 23);
            button2.TabIndex = 2;
            button2.Text = "浏览";
            button2.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            groupBox3.AutoSize = true;
            groupBox3.Controls.Add(label11);
            groupBox3.Dock = DockStyle.Fill;
            groupBox3.Location = new Point(3, 3);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(874, 356);
            groupBox3.TabIndex = 0;
            groupBox3.TabStop = false;
            groupBox3.Text = "分辨率重采";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(6, 19);
            label11.Name = "label11";
            label11.Size = new Size(50, 17);
            label11.TabIndex = 0;
            label11.Text = "label11";
            // 
            // groupBox4
            // 
            groupBox4.AutoSize = true;
            groupBox4.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            groupBox4.Controls.Add(label12);
            groupBox4.Dock = DockStyle.Fill;
            groupBox4.Location = new Point(3, 365);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(874, 356);
            groupBox4.TabIndex = 1;
            groupBox4.TabStop = false;
            groupBox4.Text = "二压";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(6, 19);
            label12.Name = "label12";
            label12.Size = new Size(50, 17);
            label12.TabIndex = 0;
            label12.Text = "label12";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(894, 811);
            Controls.Add(tabControl1);
            Controls.Add(statusStrip1);
            MaximizeBox = false;
            MinimumSize = new Size(910, 850);
            Name = "MainForm";
            Text = "吗喽导导乐";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            fileInputBox.ResumeLayout(false);
            fileInputBox.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            exportSettingBox.ResumeLayout(false);
            exportSettingBox.PerformLayout();
            flowLayout.ResumeLayout(false);
            flowLayout.PerformLayout();
            exportDetailsPanel.ResumeLayout(false);
            exportDetailsPanel.PerformLayout();
            flowLayoutPanel3.ResumeLayout(false);
            flowLayoutPanel3.PerformLayout();
            exportSettingsPages.ResumeLayout(false);
            jpgSettingsTab.ResumeLayout(false);
            jpgSettingsTab.PerformLayout();
            jpgExportSettingsPanel.ResumeLayout(false);
            jpgExportSettingsPanel.PerformLayout();
            tableLayoutPanel8.ResumeLayout(false);
            tableLayoutPanel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)jpgExportQuality).EndInit();
            pngSettingsTab.ResumeLayout(false);
            pngSettingsTab.PerformLayout();
            pngExportSettingsPanel.ResumeLayout(false);
            pngExportSettingsPanel.PerformLayout();
            tableLayoutPanel7.ResumeLayout(false);
            tableLayoutPanel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pngCompressLevel).EndInit();
            webPSettingsTab.ResumeLayout(false);
            webPSettingsTab.PerformLayout();
            webPExportSettingsPanel.ResumeLayout(false);
            webPExportSettingsPanel.PerformLayout();
            tableLayoutPanel12.ResumeLayout(false);
            tableLayoutPanel12.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)nearLosslessQuality).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).EndInit();
            exportFileNameSettingsPanel.ResumeLayout(false);
            exportFileNameSettingsPanel.PerformLayout();
            metadataBox.ResumeLayout(false);
            metadataBox.PerformLayout();
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel5.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            tabControl1.ResumeLayout(false);
            PSDExportPage.ResumeLayout(false);
            PSDExportPage.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tableLayoutPanel9.ResumeLayout(false);
            tableLayoutPanel9.PerformLayout();
            tableLayoutPanel10.ResumeLayout(false);
            tableLayoutPanel10.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
        private Button deleteSelItemInListButton;
        private Button clearFileListButton;
        private ListBox filesList;
        private GroupBox fileInputBox;
        private GroupBox exportSettingBox;
        private ComboBox comboBox1;
        private FolderBrowserDialog folderBrowserDialog1;
        private Label label6;
        private Label label7;
        private RichTextBox copyrightTextBox;
        private Label label8;
        private RichTextBox softwareTextBox;
        private Label label9;
        private RichTextBox artistTextBox;
        private Label label10;
        private RichTextBox descriptionTextBox;
        private TableLayoutPanel tableLayoutPanel5;
        private GroupBox metadataBox;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private TabControl tabControl1;
        private TabPage PSDExportPage;
        private TabPage tabPage2;
        private TableLayoutPanel tableLayoutPanel9;
        private GroupBox groupBox3;
        private Label label11;
        private GroupBox groupBox4;
        private Label label12;
        private TableLayoutPanel tableLayoutPanel10;
        private Label label1;
        private TextBox textBox1;
        private Button button2;
        private GroupBox exportFileNameSettingsPanel;
        private CheckBox checkBox1;
        private TextBox textBox4;
        private Label label16;
        private TextBox textBox3;
        private Label label15;
        private TextBox textBox2;
        private Label label14;
        private Label label13;
        private FlowLayoutPanel flowLayout;
        private TableLayoutPanel exportDetailsPanel;
        private Label label2;
        private Label label3;
        private FlowLayoutPanel flowLayoutPanel3;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private CheckBox checkBox2;
        private TextBox exportPath;
        private Button button4;
        private TabControl exportSettingsPages;
        private TabPage jpgSettingsTab;
        private GroupBox jpgExportSettingsPanel;
        private TableLayoutPanel tableLayoutPanel8;
        private NumericUpDown jpgExportQuality;
        private Label label5;
        private TabPage pngSettingsTab;
        private GroupBox pngExportSettingsPanel;
        private TableLayoutPanel tableLayoutPanel7;
        private Label label4;
        private NumericUpDown pngCompressLevel;
        private TabPage webPSettingsTab;
        private GroupBox webPExportSettingsPanel;
        private TableLayoutPanel tableLayoutPanel12;
        private RadioButton radioButton5;
        private Label label17;
        private Label label18;
        private Label label19;
        private ComboBox comboBox2;
        private FlowLayoutPanel flowLayoutPanel1;
        private RadioButton radioButton4;
        private CheckBox checkBox3;
        private NumericUpDown numericUpDown1;
        private Label label20;
        private NumericUpDown nearLosslessQuality;
        private NumericUpDown numericUpDown3;
        private Label label21;
    }
}
