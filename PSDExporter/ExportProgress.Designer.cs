namespace PSDExporter
{
    partial class ExportProgress
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            progressBar1 = new ProgressBar();
            label1 = new Label();
            panel1 = new Panel();
            label2 = new Label();
            imageExportWorker = new System.ComponentModel.BackgroundWorker();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Right;
            button1.Location = new Point(361, 130);
            button1.Name = "button1";
            button1.Size = new Size(100, 31);
            button1.TabIndex = 0;
            button1.Text = "终止";
            button1.UseVisualStyleBackColor = true;
            button1.Click += StopExportButtonClick;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.Controls.Add(progressBar1, 0, 1);
            tableLayoutPanel1.Controls.Add(button1, 2, 3);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(panel1, 0, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new Padding(20);
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.Size = new Size(484, 201);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // progressBar1
            // 
            tableLayoutPanel1.SetColumnSpan(progressBar1, 3);
            progressBar1.Dock = DockStyle.Top;
            progressBar1.Location = new Point(23, 43);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(438, 23);
            progressBar1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            tableLayoutPanel1.SetColumnSpan(label1, 3);
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Microsoft YaHei UI", 11F);
            label1.Location = new Point(23, 20);
            label1.Name = "label1";
            label1.Size = new Size(438, 20);
            label1.TabIndex = 2;
            label1.Text = "等待...";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            panel1.AutoSize = true;
            panel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel1.SetColumnSpan(panel1, 3);
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(23, 72);
            panel1.Name = "panel1";
            panel1.Size = new Size(438, 36);
            panel1.TabIndex = 4;
            // 
            // label2
            // 
            label2.Dock = DockStyle.Top;
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.RightToLeft = RightToLeft.No;
            label2.Size = new Size(438, 36);
            label2.TabIndex = 3;
            label2.Text = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // ExportProgress
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 201);
            ControlBox = false;
            Controls.Add(tableLayoutPanel1);
            MaximizeBox = false;
            MaximumSize = new Size(500, 240);
            MinimizeBox = false;
            MinimumSize = new Size(500, 240);
            Name = "ExportProgress";
            ShowIcon = false;
            Text = "导出";
            TopMost = true;
            Shown += FormShown;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TableLayoutPanel tableLayoutPanel1;
        private ProgressBar progressBar1;
        private Label label1;
        private Label label2;
        private System.ComponentModel.BackgroundWorker imageExportWorker;
        private Panel panel1;
    }
}