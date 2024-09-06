namespace ParserMiamidade
{
    partial class FileParser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FileParser));
            panel2 = new Panel();
            prgBarProgress = new ProgressBar();
            btnStart = new Button();
            tableLayoutPanel2 = new TableLayoutPanel();
            btnReset = new Button();
            fileBreaker = new NumericUpDown();
            lbl = new Label();
            rtxtBoxLogs = new RichTextBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            btnFileSave = new Button();
            btnFilePicker = new Button();
            tableLayoutPanel3 = new TableLayoutPanel();
            lblInputErrorMsg = new Label();
            label1 = new Label();
            txtBoxFilePicker = new TextBox();
            tableLayoutPanel4 = new TableLayoutPanel();
            txtboxFileSave = new TextBox();
            lblOutputErrorMsg = new Label();
            label2 = new Label();
            panel2.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)fileBreaker).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(prgBarProgress);
            panel2.Location = new Point(28, 157);
            panel2.Name = "panel2";
            panel2.Size = new Size(584, 39);
            panel2.TabIndex = 1;
            // 
            // prgBarProgress
            // 
            prgBarProgress.Dock = DockStyle.Fill;
            prgBarProgress.Location = new Point(0, 0);
            prgBarProgress.Name = "prgBarProgress";
            prgBarProgress.Size = new Size(584, 39);
            prgBarProgress.TabIndex = 0;
            // 
            // btnStart
            // 
            btnStart.BackColor = SystemColors.InactiveCaption;
            btnStart.Dock = DockStyle.Fill;
            btnStart.Location = new Point(492, 3);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(118, 35);
            btnStart.TabIndex = 1;
            btnStart.Text = "CONVERT";
            btnStart.UseVisualStyleBackColor = false;
            btnStart.Click += btnStart_Click;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.BackColor = SystemColors.ButtonFace;
            tableLayoutPanel2.ColumnCount = 4;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 24F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 36F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.Controls.Add(btnStart, 3, 0);
            tableLayoutPanel2.Controls.Add(btnReset, 2, 0);
            tableLayoutPanel2.Controls.Add(fileBreaker, 1, 0);
            tableLayoutPanel2.Controls.Add(lbl, 0, 0);
            tableLayoutPanel2.Location = new Point(13, 107);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(613, 41);
            tableLayoutPanel2.TabIndex = 3;
            // 
            // btnReset
            // 
            btnReset.BackColor = SystemColors.InactiveCaption;
            btnReset.Dock = DockStyle.Fill;
            btnReset.Location = new Point(370, 3);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(116, 35);
            btnReset.TabIndex = 2;
            btnReset.Text = "RESET";
            btnReset.UseVisualStyleBackColor = false;
            btnReset.Click += btnReset_Click;
            // 
            // fileBreaker
            // 
            fileBreaker.Anchor = AnchorStyles.Left;
            fileBreaker.Location = new Point(150, 9);
            fileBreaker.Maximum = new decimal(new int[] { 1410065408, 2, 0, 0 });
            fileBreaker.Name = "fileBreaker";
            fileBreaker.Size = new Size(120, 23);
            fileBreaker.TabIndex = 3;
            fileBreaker.Value = new decimal(new int[] { 30000, 0, 0, 0 });
            // 
            // lbl
            // 
            lbl.Anchor = AnchorStyles.Left;
            lbl.AutoSize = true;
            lbl.Location = new Point(3, 13);
            lbl.Name = "lbl";
            lbl.Size = new Size(135, 15);
            lbl.TabIndex = 3;
            lbl.Text = "Number of rows to split:";
            // 
            // rtxtBoxLogs
            // 
            rtxtBoxLogs.Location = new Point(17, 202);
            rtxtBoxLogs.Name = "rtxtBoxLogs";
            rtxtBoxLogs.ReadOnly = true;
            rtxtBoxLogs.Size = new Size(605, 140);
            rtxtBoxLogs.TabIndex = 4;
            rtxtBoxLogs.Text = "";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 90F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Controls.Add(btnFileSave, 1, 1);
            tableLayoutPanel1.Controls.Add(btnFilePicker, 1, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel4, 0, 1);
            tableLayoutPanel1.Location = new Point(6, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(629, 98);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // btnFileSave
            // 
            btnFileSave.Anchor = AnchorStyles.None;
            btnFileSave.Image = Properties.Resources._30x30Floppylogo;
            btnFileSave.Location = new Point(577, 58);
            btnFileSave.Name = "btnFileSave";
            btnFileSave.Size = new Size(41, 31);
            btnFileSave.TabIndex = 5;
            btnFileSave.UseVisualStyleBackColor = true;
            btnFileSave.Click += btnFileSave_Click;
            // 
            // btnFilePicker
            // 
            btnFilePicker.Anchor = AnchorStyles.None;
            btnFilePicker.Image = Properties.Resources._30x30FileLogo;
            btnFilePicker.Location = new Point(577, 9);
            btnFilePicker.Name = "btnFilePicker";
            btnFilePicker.Size = new Size(41, 31);
            btnFilePicker.TabIndex = 4;
            btnFilePicker.UseVisualStyleBackColor = true;
            btnFilePicker.Click += btnFilePicker_Click;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 85F));
            tableLayoutPanel3.Controls.Add(lblInputErrorMsg, 1, 1);
            tableLayoutPanel3.Controls.Add(label1, 0, 0);
            tableLayoutPanel3.Controls.Add(txtBoxFilePicker, 1, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(3, 3);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 70F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            tableLayoutPanel3.Size = new Size(560, 43);
            tableLayoutPanel3.TabIndex = 6;
            // 
            // lblInputErrorMsg
            // 
            lblInputErrorMsg.AutoSize = true;
            lblInputErrorMsg.Font = new Font("Segoe UI", 6.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblInputErrorMsg.Location = new Point(87, 30);
            lblInputErrorMsg.Name = "lblInputErrorMsg";
            lblInputErrorMsg.Size = new Size(92, 12);
            lblInputErrorMsg.TabIndex = 5;
            lblInputErrorMsg.Text = "this path doesn't esist.";
            lblInputErrorMsg.Visible = false;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Location = new Point(23, 7);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 0;
            label1.Text = "Input:";
            // 
            // txtBoxFilePicker
            // 
            txtBoxFilePicker.Anchor = AnchorStyles.None;
            txtBoxFilePicker.Location = new Point(87, 3);
            txtBoxFilePicker.Name = "txtBoxFilePicker";
            txtBoxFilePicker.Size = new Size(470, 23);
            txtBoxFilePicker.TabIndex = 2;
            txtBoxFilePicker.TextChanged += txtBoxFilePicker_TextChanged;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 2;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 85F));
            tableLayoutPanel4.Controls.Add(txtboxFileSave, 1, 0);
            tableLayoutPanel4.Controls.Add(lblOutputErrorMsg, 1, 1);
            tableLayoutPanel4.Controls.Add(label2, 0, 0);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(3, 52);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 2;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 70F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            tableLayoutPanel4.Size = new Size(560, 43);
            tableLayoutPanel4.TabIndex = 7;
            // 
            // txtboxFileSave
            // 
            txtboxFileSave.Anchor = AnchorStyles.None;
            txtboxFileSave.Location = new Point(87, 3);
            txtboxFileSave.Name = "txtboxFileSave";
            txtboxFileSave.Size = new Size(470, 23);
            txtboxFileSave.TabIndex = 3;
            txtboxFileSave.TextChanged += txtboxFileSave_TextChanged;
            // 
            // lblOutputErrorMsg
            // 
            lblOutputErrorMsg.AutoSize = true;
            lblOutputErrorMsg.Font = new Font("Segoe UI", 6.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblOutputErrorMsg.Location = new Point(87, 30);
            lblOutputErrorMsg.Name = "lblOutputErrorMsg";
            lblOutputErrorMsg.Size = new Size(92, 12);
            lblOutputErrorMsg.TabIndex = 6;
            lblOutputErrorMsg.Text = "this path doesn't esist.";
            lblOutputErrorMsg.Visible = false;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Location = new Point(18, 7);
            label2.Name = "label2";
            label2.Size = new Size(48, 15);
            label2.TabIndex = 1;
            label2.Text = "Output:";
            // 
            // FileParser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(640, 351);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(rtxtBoxLogs);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(panel2);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(656, 390);
            MinimumSize = new Size(656, 390);
            Name = "FileParser";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Parser Realtor";
            panel2.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)fileBreaker).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel2;
        private Button btnStart;
        private ProgressBar prgBarProgress;
        private TableLayoutPanel tableLayoutPanel2;
        private Button btnReset;
        private RichTextBox rtxtBoxLogs;
        private NumericUpDown fileBreaker;
        private TableLayoutPanel tableLayoutPanel1;
        private Button btnFileSave;
        private Label label1;
        private Label label2;
        private TextBox txtBoxFilePicker;
        private TextBox txtboxFileSave;
        private Button btnFilePicker;
        private TableLayoutPanel tableLayoutPanel3;
        private Label lblInputErrorMsg;
        private TableLayoutPanel tableLayoutPanel4;
        private Label lblOutputErrorMsg;
        private Label lbl;
    }
}
