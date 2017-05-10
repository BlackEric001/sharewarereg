namespace LicenseShow_TrialCheck
{
    partial class RegistrationForm
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
            this.btnRegisterHashKey = new System.Windows.Forms.Button();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxKey = new System.Windows.Forms.TextBox();
            this.lbRegistrationName = new System.Windows.Forms.Label();
            this.lbRegistrationKey = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.btnRegisterRSAKey = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRegisterHashKey
            // 
            this.btnRegisterHashKey.Location = new System.Drawing.Point(14, 201);
            this.btnRegisterHashKey.Name = "btnRegisterHashKey";
            this.btnRegisterHashKey.Size = new System.Drawing.Size(111, 23);
            this.btnRegisterHashKey.TabIndex = 0;
            this.btnRegisterHashKey.Text = "Register Hash Key";
            this.btnRegisterHashKey.UseVisualStyleBackColor = true;
            this.btnRegisterHashKey.Click += new System.EventHandler(this.btnRegisterHaskKey_Click);
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(16, 34);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(375, 20);
            this.textBoxName.TabIndex = 1;
            // 
            // textBoxKey
            // 
            this.textBoxKey.Location = new System.Drawing.Point(16, 89);
            this.textBoxKey.Multiline = true;
            this.textBoxKey.Name = "textBoxKey";
            this.textBoxKey.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxKey.Size = new System.Drawing.Size(375, 96);
            this.textBoxKey.TabIndex = 2;
            // 
            // lbRegistrationName
            // 
            this.lbRegistrationName.AutoSize = true;
            this.lbRegistrationName.Location = new System.Drawing.Point(13, 18);
            this.lbRegistrationName.Name = "lbRegistrationName";
            this.lbRegistrationName.Size = new System.Drawing.Size(38, 13);
            this.lbRegistrationName.TabIndex = 3;
            this.lbRegistrationName.Text = "Name:";
            // 
            // lbRegistrationKey
            // 
            this.lbRegistrationKey.AutoSize = true;
            this.lbRegistrationKey.Location = new System.Drawing.Point(13, 73);
            this.lbRegistrationKey.Name = "lbRegistrationKey";
            this.lbRegistrationKey.Size = new System.Drawing.Size(28, 13);
            this.lbRegistrationKey.TabIndex = 4;
            this.lbRegistrationKey.Text = "Key:";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(276, 206);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(113, 13);
            this.linkLabel1.TabIndex = 5;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Get Registration Key :)";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // btnRegisterRSAKey
            // 
            this.btnRegisterRSAKey.Location = new System.Drawing.Point(141, 201);
            this.btnRegisterRSAKey.Name = "btnRegisterRSAKey";
            this.btnRegisterRSAKey.Size = new System.Drawing.Size(129, 23);
            this.btnRegisterRSAKey.TabIndex = 6;
            this.btnRegisterRSAKey.Text = "Register RSA Key";
            this.btnRegisterRSAKey.UseVisualStyleBackColor = true;
            this.btnRegisterRSAKey.Click += new System.EventHandler(this.btnRegisterRSAKey_Click);
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 236);
            this.Controls.Add(this.btnRegisterRSAKey);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.lbRegistrationKey);
            this.Controls.Add(this.lbRegistrationName);
            this.Controls.Add(this.textBoxKey);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.btnRegisterHashKey);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RegistrationForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Registration Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRegisterHashKey;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxKey;
        private System.Windows.Forms.Label lbRegistrationName;
        private System.Windows.Forms.Label lbRegistrationKey;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button btnRegisterRSAKey;
    }
}