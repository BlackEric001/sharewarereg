namespace LicenseShow_TrialCheck
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
            this.btn_ShowLicense = new System.Windows.Forms.Button();
            this.btn_register = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_ShowLicense
            // 
            this.btn_ShowLicense.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_ShowLicense.Location = new System.Drawing.Point(238, 273);
            this.btn_ShowLicense.Name = "btn_ShowLicense";
            this.btn_ShowLicense.Size = new System.Drawing.Size(96, 23);
            this.btn_ShowLicense.TabIndex = 0;
            this.btn_ShowLicense.Text = "Show License";
            this.btn_ShowLicense.UseVisualStyleBackColor = true;
            this.btn_ShowLicense.Click += new System.EventHandler(this.btn_ShowLicense_Click);
            // 
            // btn_register
            // 
            this.btn_register.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_register.Location = new System.Drawing.Point(12, 273);
            this.btn_register.Name = "btn_register";
            this.btn_register.Size = new System.Drawing.Size(97, 23);
            this.btn_register.TabIndex = 1;
            this.btn_register.Text = "Register";
            this.btn_register.UseVisualStyleBackColor = true;
            this.btn_register.Click += new System.EventHandler(this.btn_register_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_register);
            this.panel1.Controls.Add(this.btn_ShowLicense);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(346, 308);
            this.panel1.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 308);
            this.Controls.Add(this.panel1);
            this.Name = "MainForm";
            this.Text = "Main Form. Trial Left:";
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_ShowLicense;
        private System.Windows.Forms.Button btn_register;
        private System.Windows.Forms.Panel panel1;
    }
}

