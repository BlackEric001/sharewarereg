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
            this.btn_Register = new System.Windows.Forms.Button();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxKey = new System.Windows.Forms.TextBox();
            this.lbRegistrationName = new System.Windows.Forms.Label();
            this.lbRegistrationKey = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // btn_Register
            // 
            this.btn_Register.Location = new System.Drawing.Point(16, 154);
            this.btn_Register.Name = "btn_Register";
            this.btn_Register.Size = new System.Drawing.Size(75, 23);
            this.btn_Register.TabIndex = 0;
            this.btn_Register.Text = "Register";
            this.btn_Register.UseVisualStyleBackColor = true;
            this.btn_Register.Click += new System.EventHandler(this.btn_Register_Click);
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(16, 34);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(256, 20);
            this.textBoxName.TabIndex = 1;
            // 
            // textBoxKey
            // 
            this.textBoxKey.Location = new System.Drawing.Point(16, 89);
            this.textBoxKey.Name = "textBoxKey";
            this.textBoxKey.Size = new System.Drawing.Size(256, 20);
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
            this.linkLabel1.Location = new System.Drawing.Point(168, 164);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(104, 13);
            this.linkLabel1.TabIndex = 5;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Get Registration Key";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 190);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.lbRegistrationKey);
            this.Controls.Add(this.lbRegistrationName);
            this.Controls.Add(this.textBoxKey);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.btn_Register);
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

        private System.Windows.Forms.Button btn_Register;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxKey;
        private System.Windows.Forms.Label lbRegistrationName;
        private System.Windows.Forms.Label lbRegistrationKey;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}