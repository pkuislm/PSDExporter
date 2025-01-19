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
            groupBox5 = new GroupBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel3 = new TableLayoutPanel();
            deleteSelItemInListButton = new Button();
            clearFileListButton = new Button();
            filesList = new ListBox();
            groupBox1 = new GroupBox();
            tableLayoutPanel6 = new TableLayoutPanel();
            pngExportSettingsPanel = new GroupBox();
            tableLayoutPanel7 = new TableLayoutPanel();
            label4 = new Label();
            pngCompressLevel = new NumericUpDown();
            jpgExportSettingsPanel = new GroupBox();
            tableLayoutPanel8 = new TableLayoutPanel();
            jpgExportQuality = new NumericUpDown();
            label5 = new Label();
            tableLayoutPanel4 = new TableLayoutPanel();
            label2 = new Label();
            label3 = new Label();
            flowLayoutPanel3 = new FlowLayoutPanel();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            exportPath = new TextBox();
            button4 = new Button();
            groupBox6 = new GroupBox();
            checkBox1 = new CheckBox();
            textBox4 = new TextBox();
            label16 = new Label();
            textBox3 = new TextBox();
            label15 = new Label();
            textBox2 = new TextBox();
            label14 = new Label();
            label13 = new Label();
            groupBox2 = new GroupBox();
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
            tabPage1 = new TabPage();
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
            groupBox7 = new GroupBox();
            checkBox2 = new CheckBox();
            tableLayoutPanel11 = new TableLayoutPanel();
            tableLayoutPanel1.SuspendLayout();
            groupBox5.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            groupBox1.SuspendLayout();
            tableLayoutPanel6.SuspendLayout();
            pngExportSettingsPanel.SuspendLayout();
            tableLayoutPanel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pngCompressLevel).BeginInit();
            jpgExportSettingsPanel.SuspendLayout();
            tableLayoutPanel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)jpgExportQuality).BeginInit();
            tableLayoutPanel4.SuspendLayout();
            flowLayoutPanel3.SuspendLayout();
            groupBox6.SuspendLayout();
            groupBox2.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            statusStrip1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            tableLayoutPanel9.SuspendLayout();
            tableLayoutPanel10.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox7.SuspendLayout();
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
            button1.Text = "开始导出";
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
            tableLayoutPanel1.Controls.Add(groupBox5, 0, 0);
            tableLayoutPanel1.Controls.Add(groupBox1, 0, 1);
            tableLayoutPanel1.Controls.Add(groupBox2, 4, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(3, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.Size = new Size(880, 753);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // groupBox5
            // 
            groupBox5.AutoSize = true;
            groupBox5.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel1.SetColumnSpan(groupBox5, 8);
            groupBox5.Controls.Add(tableLayoutPanel2);
            groupBox5.Dock = DockStyle.Fill;
            groupBox5.Location = new Point(3, 3);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(874, 229);
            groupBox5.TabIndex = 5;
            groupBox5.TabStop = false;
            groupBox5.Text = "拖拽包含.psd的文件夹或者.psd文件至下方列表中";
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
            // groupBox1
            // 
            groupBox1.AutoSize = true;
            groupBox1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel1.SetColumnSpan(groupBox1, 4);
            groupBox1.Controls.Add(tableLayoutPanel6);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(3, 238);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(434, 513);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "导出设定";
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.AutoSize = true;
            tableLayoutPanel6.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel6.ColumnCount = 1;
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel6.Controls.Add(pngExportSettingsPanel, 0, 2);
            tableLayoutPanel6.Controls.Add(jpgExportSettingsPanel, 0, 1);
            tableLayoutPanel6.Controls.Add(tableLayoutPanel4, 0, 0);
            tableLayoutPanel6.Controls.Add(groupBox6, 0, 3);
            tableLayoutPanel6.Controls.Add(groupBox7, 0, 4);
            tableLayoutPanel6.Dock = DockStyle.Fill;
            tableLayoutPanel6.Location = new Point(3, 19);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 5;
            tableLayoutPanel6.RowStyles.Add(new RowStyle());
            tableLayoutPanel6.RowStyles.Add(new RowStyle());
            tableLayoutPanel6.RowStyles.Add(new RowStyle());
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Absolute, 82F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Absolute, 82F));
            tableLayoutPanel6.Size = new Size(428, 491);
            tableLayoutPanel6.TabIndex = 1;
            // 
            // pngExportSettingsPanel
            // 
            pngExportSettingsPanel.AutoSize = true;
            pngExportSettingsPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            pngExportSettingsPanel.Controls.Add(tableLayoutPanel7);
            pngExportSettingsPanel.Dock = DockStyle.Top;
            pngExportSettingsPanel.Enabled = false;
            pngExportSettingsPanel.Location = new Point(3, 128);
            pngExportSettingsPanel.Name = "pngExportSettingsPanel";
            pngExportSettingsPanel.Size = new Size(422, 51);
            pngExportSettingsPanel.TabIndex = 2;
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
            tableLayoutPanel7.Size = new Size(416, 29);
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
            pngCompressLevel.Location = new Point(293, 3);
            pngCompressLevel.Maximum = new decimal(new int[] { 9, 0, 0, 0 });
            pngCompressLevel.Name = "pngCompressLevel";
            pngCompressLevel.Size = new Size(120, 23);
            pngCompressLevel.TabIndex = 1;
            pngCompressLevel.Value = new decimal(new int[] { 9, 0, 0, 0 });
            // 
            // jpgExportSettingsPanel
            // 
            jpgExportSettingsPanel.AutoSize = true;
            jpgExportSettingsPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            jpgExportSettingsPanel.Controls.Add(tableLayoutPanel8);
            jpgExportSettingsPanel.Dock = DockStyle.Top;
            jpgExportSettingsPanel.Location = new Point(3, 71);
            jpgExportSettingsPanel.Name = "jpgExportSettingsPanel";
            jpgExportSettingsPanel.Size = new Size(422, 51);
            jpgExportSettingsPanel.TabIndex = 1;
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
            tableLayoutPanel8.Size = new Size(416, 29);
            tableLayoutPanel8.TabIndex = 0;
            // 
            // jpgExportQuality
            // 
            jpgExportQuality.Anchor = AnchorStyles.Right;
            jpgExportQuality.Location = new Point(293, 3);
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
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.AutoSize = true;
            tableLayoutPanel4.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel4.ColumnCount = 3;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel4.Controls.Add(label2, 0, 0);
            tableLayoutPanel4.Controls.Add(label3, 0, 1);
            tableLayoutPanel4.Controls.Add(flowLayoutPanel3, 1, 0);
            tableLayoutPanel4.Controls.Add(exportPath, 1, 1);
            tableLayoutPanel4.Controls.Add(button4, 2, 1);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(3, 3);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 2;
            tableLayoutPanel4.RowStyles.Add(new RowStyle());
            tableLayoutPanel4.RowStyles.Add(new RowStyle());
            tableLayoutPanel4.Size = new Size(422, 62);
            tableLayoutPanel4.TabIndex = 0;
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
            tableLayoutPanel4.SetColumnSpan(flowLayoutPanel3, 2);
            flowLayoutPanel3.Controls.Add(radioButton1);
            flowLayoutPanel3.Controls.Add(radioButton2);
            flowLayoutPanel3.Controls.Add(checkBox2);
            flowLayoutPanel3.Dock = DockStyle.Fill;
            flowLayoutPanel3.Location = new Point(87, 3);
            flowLayoutPanel3.Name = "flowLayoutPanel3";
            flowLayoutPanel3.Size = new Size(332, 27);
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
            radioButton1.CheckedChanged += RadioButtonCheckedChanged;
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
            radioButton2.CheckedChanged += RadioButtonCheckedChanged;
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
            button4.Click += button4_Click;
            // 
            // groupBox6
            // 
            groupBox6.AutoSize = true;
            groupBox6.Controls.Add(checkBox1);
            groupBox6.Controls.Add(textBox4);
            groupBox6.Controls.Add(label16);
            groupBox6.Controls.Add(textBox3);
            groupBox6.Controls.Add(label15);
            groupBox6.Controls.Add(textBox2);
            groupBox6.Controls.Add(label14);
            groupBox6.Controls.Add(label13);
            groupBox6.Dock = DockStyle.Fill;
            groupBox6.Location = new Point(3, 185);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(422, 76);
            groupBox6.TabIndex = 3;
            groupBox6.TabStop = false;
            groupBox6.Text = "输出文件名格式";
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
            // groupBox2
            // 
            groupBox2.AutoSize = true;
            groupBox2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel1.SetColumnSpan(groupBox2, 4);
            groupBox2.Controls.Add(tableLayoutPanel5);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Location = new Point(443, 238);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(434, 513);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "元数据";
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
            comboBox1.Items.AddRange(new object[] { "Adobe RGB", "sRGB", "DCI-P3", "无" });
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
            tabControl1.Controls.Add(tabPage1);
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
            // tabPage1
            // 
            tabPage1.Controls.Add(tableLayoutPanel1);
            tabPage1.Location = new Point(4, 26);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(886, 759);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "PSD导出";
            tabPage1.UseVisualStyleBackColor = true;
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
            // groupBox7
            // 
            groupBox7.Controls.Add(tableLayoutPanel11);
            groupBox7.Dock = DockStyle.Fill;
            groupBox7.Location = new Point(3, 267);
            groupBox7.Name = "groupBox7";
            groupBox7.Size = new Size(422, 221);
            groupBox7.TabIndex = 4;
            groupBox7.TabStop = false;
            groupBox7.Text = "图片处理";
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(114, 3);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(99, 21);
            checkBox2.TabIndex = 2;
            checkBox2.Text = "强制灰度输出";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel11
            // 
            tableLayoutPanel11.ColumnCount = 1;
            tableLayoutPanel11.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel11.Dock = DockStyle.Fill;
            tableLayoutPanel11.Location = new Point(3, 19);
            tableLayoutPanel11.Name = "tableLayoutPanel11";
            tableLayoutPanel11.RowCount = 2;
            tableLayoutPanel11.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel11.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel11.Size = new Size(416, 199);
            tableLayoutPanel11.TabIndex = 0;
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
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            tableLayoutPanel6.ResumeLayout(false);
            tableLayoutPanel6.PerformLayout();
            pngExportSettingsPanel.ResumeLayout(false);
            pngExportSettingsPanel.PerformLayout();
            tableLayoutPanel7.ResumeLayout(false);
            tableLayoutPanel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pngCompressLevel).EndInit();
            jpgExportSettingsPanel.ResumeLayout(false);
            jpgExportSettingsPanel.PerformLayout();
            tableLayoutPanel8.ResumeLayout(false);
            tableLayoutPanel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)jpgExportQuality).EndInit();
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            flowLayoutPanel3.ResumeLayout(false);
            flowLayoutPanel3.PerformLayout();
            groupBox6.ResumeLayout(false);
            groupBox6.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel5.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
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
            groupBox7.ResumeLayout(false);
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
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private TableLayoutPanel tableLayoutPanel4;
        private Label label2;
        private Label label3;
        private FlowLayoutPanel flowLayoutPanel3;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private TextBox exportPath;
        private Button button4;
        private ComboBox comboBox1;
        private FolderBrowserDialog folderBrowserDialog1;
        private GroupBox jpgExportSettingsPanel;
        private GroupBox pngExportSettingsPanel;
        private Label label5;
        private Label label4;
        private Label label6;
        private Label label7;
        private RichTextBox copyrightTextBox;
        private Label label8;
        private RichTextBox softwareTextBox;
        private Label label9;
        private RichTextBox artistTextBox;
        private Label label10;
        private RichTextBox descriptionTextBox;
        private TableLayoutPanel tableLayoutPanel6;
        private TableLayoutPanel tableLayoutPanel5;
        private GroupBox groupBox5;
        private NumericUpDown jpgExportQuality;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private TableLayoutPanel tableLayoutPanel7;
        private NumericUpDown pngCompressLevel;
        private TableLayoutPanel tableLayoutPanel8;
        private TabControl tabControl1;
        private TabPage tabPage1;
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
        private GroupBox groupBox6;
        private TextBox textBox2;
        private Label label14;
        private Label label13;
        private CheckBox checkBox1;
        private TextBox textBox4;
        private Label label16;
        private TextBox textBox3;
        private Label label15;
        private GroupBox groupBox7;
        private CheckBox checkBox2;
        private TableLayoutPanel tableLayoutPanel11;
    }
}
