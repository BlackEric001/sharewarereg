namespace WPKeyGenerator
{
    partial class MainForm
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
            this.lbName = new System.Windows.Forms.Label();
            this.lbKey = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxKey = new System.Windows.Forms.TextBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.comboBoxKeyType = new System.Windows.Forms.ComboBox();
            this.lbKeyType = new System.Windows.Forms.Label();
            this.pnlButtons = new System.Windows.Forms.Panel();
            this.btn_ValidateKey = new System.Windows.Forms.Button();
            this.btn_CopyToClipboard = new System.Windows.Forms.Button();
            this.btn_SaveToFile = new System.Windows.Forms.Button();
            this.btn_GenerateKey = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.statusStrip1.SuspendLayout();
            this.pnlButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(17, 52);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(35, 13);
            this.lbName.TabIndex = 0;
            this.lbName.Text = "Name";
            // 
            // lbKey
            // 
            this.lbKey.AutoSize = true;
            this.lbKey.Location = new System.Drawing.Point(17, 100);
            this.lbKey.Name = "lbKey";
            this.lbKey.Size = new System.Drawing.Size(25, 13);
            this.lbKey.TabIndex = 1;
            this.lbKey.Text = "Key";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(20, 68);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(416, 20);
            this.textBoxName.TabIndex = 2;
            // 
            // textBoxKey
            // 
            this.textBoxKey.Location = new System.Drawing.Point(20, 116);
            this.textBoxKey.Multiline = true;
            this.textBoxKey.Name = "textBoxKey";
            this.textBoxKey.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxKey.Size = new System.Drawing.Size(416, 70);
            this.textBoxKey.TabIndex = 3;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 240);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(444, 22);
            this.statusStrip1.TabIndex = 8;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusLabel
            // 
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(66, 17);
            this.statusLabel.Text = "statusLabel";
            // 
            // comboBoxKeyType
            // 
            this.comboBoxKeyType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxKeyType.FormattingEnabled = true;
            this.comboBoxKeyType.Items.AddRange(new object[] {
            "Hash",
            "Asymmetric"});
            this.comboBoxKeyType.Location = new System.Drawing.Point(20, 24);
            this.comboBoxKeyType.Name = "comboBoxKeyType";
            this.comboBoxKeyType.Size = new System.Drawing.Size(416, 21);
            this.comboBoxKeyType.TabIndex = 9;
            this.comboBoxKeyType.SelectedIndexChanged += new System.EventHandler(this.comboBoxKeyType_SelectedIndexChanged);
            // 
            // lbKeyType
            // 
            this.lbKeyType.AutoSize = true;
            this.lbKeyType.Location = new System.Drawing.Point(17, 8);
            this.lbKeyType.Name = "lbKeyType";
            this.lbKeyType.Size = new System.Drawing.Size(52, 13);
            this.lbKeyType.TabIndex = 10;
            this.lbKeyType.Text = "Key Type";
            // 
            // pnlButtons
            // 
            this.pnlButtons.Controls.Add(this.btn_ValidateKey);
            this.pnlButtons.Controls.Add(this.btn_CopyToClipboard);
            this.pnlButtons.Controls.Add(this.btn_SaveToFile);
            this.pnlButtons.Controls.Add(this.btn_GenerateKey);
            this.pnlButtons.Location = new System.Drawing.Point(0, 192);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Size = new System.Drawing.Size(444, 45);
            this.pnlButtons.TabIndex = 11;
            // 
            // btn_ValidateKey
            // 
            this.btn_ValidateKey.Location = new System.Drawing.Point(122, 11);
            this.btn_ValidateKey.Name = "btn_ValidateKey";
            this.btn_ValidateKey.Size = new System.Drawing.Size(84, 23);
            this.btn_ValidateKey.TabIndex = 11;
            this.btn_ValidateKey.Text = "Validate Key";
            this.btn_ValidateKey.UseVisualStyleBackColor = true;
            this.btn_ValidateKey.Click += new System.EventHandler(this.btn_ValidateKey_Click);
            // 
            // btn_CopyToClipboard
            // 
            this.btn_CopyToClipboard.Location = new System.Drawing.Point(325, 11);
            this.btn_CopyToClipboard.Name = "btn_CopyToClipboard";
            this.btn_CopyToClipboard.Size = new System.Drawing.Size(111, 23);
            this.btn_CopyToClipboard.TabIndex = 10;
            this.btn_CopyToClipboard.Text = "Copy To Clipboard";
            this.btn_CopyToClipboard.UseVisualStyleBackColor = true;
            this.btn_CopyToClipboard.Click += new System.EventHandler(this.btn_CopyToClipboard_Click);
            // 
            // btn_SaveToFile
            // 
            this.btn_SaveToFile.Location = new System.Drawing.Point(212, 11);
            this.btn_SaveToFile.Name = "btn_SaveToFile";
            this.btn_SaveToFile.Size = new System.Drawing.Size(107, 23);
            this.btn_SaveToFile.TabIndex = 9;
            this.btn_SaveToFile.Text = "&Save To File";
            this.btn_SaveToFile.UseVisualStyleBackColor = true;
            this.btn_SaveToFile.Click += new System.EventHandler(this.btn_SaveToFile_Click);
            // 
            // btn_GenerateKey
            // 
            this.btn_GenerateKey.Location = new System.Drawing.Point(20, 11);
            this.btn_GenerateKey.Name = "btn_GenerateKey";
            this.btn_GenerateKey.Size = new System.Drawing.Size(96, 23);
            this.btn_GenerateKey.TabIndex = 8;
            this.btn_GenerateKey.Text = "Generate Key";
            this.btn_GenerateKey.UseVisualStyleBackColor = true;
            this.btn_GenerateKey.Click += new System.EventHandler(this.btn_GenerateKey_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 262);
            this.Controls.Add(this.pnlButtons);
            this.Controls.Add(this.lbKeyType);
            this.Controls.Add(this.comboBoxKeyType);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.textBoxKey);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.lbKey);
            this.Controls.Add(this.lbName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(460, 300);
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Test Key Generator 0.1 beta";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.pnlButtons.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbKey;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxKey;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel;
        private System.Windows.Forms.ComboBox comboBoxKeyType;
        private System.Windows.Forms.Label lbKeyType;
        private System.Windows.Forms.Panel pnlButtons;
        private System.Windows.Forms.Button btn_ValidateKey;
        private System.Windows.Forms.Button btn_CopyToClipboard;
        private System.Windows.Forms.Button btn_SaveToFile;
        private System.Windows.Forms.Button btn_GenerateKey;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

