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
            this.btn_GenerateKey = new System.Windows.Forms.Button();
            this.btn_SaveToFile = new System.Windows.Forms.Button();
            this.btn_CopyToClipboard = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.btn_ValidateKey = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(17, 21);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(35, 13);
            this.lbName.TabIndex = 0;
            this.lbName.Text = "Name";
            // 
            // lbKey
            // 
            this.lbKey.AutoSize = true;
            this.lbKey.Location = new System.Drawing.Point(17, 84);
            this.lbKey.Name = "lbKey";
            this.lbKey.Size = new System.Drawing.Size(25, 13);
            this.lbKey.TabIndex = 1;
            this.lbKey.Text = "Key";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(20, 37);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(416, 20);
            this.textBoxName.TabIndex = 2;
            // 
            // textBoxKey
            // 
            this.textBoxKey.Location = new System.Drawing.Point(20, 100);
            this.textBoxKey.Name = "textBoxKey";
            this.textBoxKey.Size = new System.Drawing.Size(416, 20);
            this.textBoxKey.TabIndex = 3;
            // 
            // btn_GenerateKey
            // 
            this.btn_GenerateKey.Location = new System.Drawing.Point(20, 142);
            this.btn_GenerateKey.Name = "btn_GenerateKey";
            this.btn_GenerateKey.Size = new System.Drawing.Size(96, 23);
            this.btn_GenerateKey.TabIndex = 4;
            this.btn_GenerateKey.Text = "Generate Key";
            this.btn_GenerateKey.UseVisualStyleBackColor = true;
            this.btn_GenerateKey.Click += new System.EventHandler(this.btn_GenerateKey_Click);
            // 
            // btn_SaveToFile
            // 
            this.btn_SaveToFile.Location = new System.Drawing.Point(212, 142);
            this.btn_SaveToFile.Name = "btn_SaveToFile";
            this.btn_SaveToFile.Size = new System.Drawing.Size(107, 23);
            this.btn_SaveToFile.TabIndex = 5;
            this.btn_SaveToFile.Text = "&Save To File";
            this.btn_SaveToFile.UseVisualStyleBackColor = true;
            this.btn_SaveToFile.Click += new System.EventHandler(this.btn_SaveToFile_Click);
            // 
            // btn_CopyToClipboard
            // 
            this.btn_CopyToClipboard.Location = new System.Drawing.Point(325, 142);
            this.btn_CopyToClipboard.Name = "btn_CopyToClipboard";
            this.btn_CopyToClipboard.Size = new System.Drawing.Size(111, 23);
            this.btn_CopyToClipboard.TabIndex = 6;
            this.btn_CopyToClipboard.Text = "Copy To Clipboard";
            this.btn_CopyToClipboard.UseVisualStyleBackColor = true;
            this.btn_CopyToClipboard.Click += new System.EventHandler(this.btn_CopyToClipboard_Click);
            // 
            // btn_ValidateKey
            // 
            this.btn_ValidateKey.Location = new System.Drawing.Point(122, 142);
            this.btn_ValidateKey.Name = "btn_ValidateKey";
            this.btn_ValidateKey.Size = new System.Drawing.Size(84, 23);
            this.btn_ValidateKey.TabIndex = 7;
            this.btn_ValidateKey.Text = "Validate Key";
            this.btn_ValidateKey.UseVisualStyleBackColor = true;
            this.btn_ValidateKey.Click += new System.EventHandler(this.btn_ValidateKey_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 182);
            this.Controls.Add(this.btn_ValidateKey);
            this.Controls.Add(this.btn_CopyToClipboard);
            this.Controls.Add(this.btn_SaveToFile);
            this.Controls.Add(this.btn_GenerateKey);
            this.Controls.Add(this.textBoxKey);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.lbKey);
            this.Controls.Add(this.lbName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(460, 220);
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WP Key Generator 0.1 alpha";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbKey;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxKey;
        private System.Windows.Forms.Button btn_GenerateKey;
        private System.Windows.Forms.Button btn_SaveToFile;
        private System.Windows.Forms.Button btn_CopyToClipboard;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button btn_ValidateKey;
    }
}

