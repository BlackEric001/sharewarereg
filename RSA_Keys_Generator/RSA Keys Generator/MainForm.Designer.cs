namespace RSATest
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.GenerateKeyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SavePrivateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SavePublicToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LoadKeyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 380);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(533, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.GenerateKeyToolStripMenuItem,
            this.SavePrivateToolStripMenuItem,
            this.SavePublicToolStripMenuItem,
            this.LoadKeyToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(533, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // GenerateKeyToolStripMenuItem
            // 
            this.GenerateKeyToolStripMenuItem.Name = "GenerateKeyToolStripMenuItem";
            this.GenerateKeyToolStripMenuItem.Size = new System.Drawing.Size(135, 20);
            this.GenerateKeyToolStripMenuItem.Text = "Сгенерировать ключ";
            this.GenerateKeyToolStripMenuItem.Click += new System.EventHandler(this.GenerateKeyToolStripMenuItem_Click);
            // 
            // SavePrivateToolStripMenuItem
            // 
            this.SavePrivateToolStripMenuItem.Name = "SavePrivateToolStripMenuItem";
            this.SavePrivateToolStripMenuItem.Size = new System.Drawing.Size(116, 20);
            this.SavePrivateToolStripMenuItem.Text = "Сохранить private";
            this.SavePrivateToolStripMenuItem.Click += new System.EventHandler(this.SavePrivateToolStripMenuItem_Click);
            // 
            // SavePublicToolStripMenuItem
            // 
            this.SavePublicToolStripMenuItem.Name = "SavePublicToolStripMenuItem";
            this.SavePublicToolStripMenuItem.Size = new System.Drawing.Size(113, 20);
            this.SavePublicToolStripMenuItem.Text = "Сохранить public";
            this.SavePublicToolStripMenuItem.Click += new System.EventHandler(this.SavePublicToolStripMenuItem_Click);
            // 
            // LoadKeyToolStripMenuItem
            // 
            this.LoadKeyToolStripMenuItem.Name = "LoadKeyToolStripMenuItem";
            this.LoadKeyToolStripMenuItem.Size = new System.Drawing.Size(106, 20);
            this.LoadKeyToolStripMenuItem.Text = "Загрузить ключ";
            this.LoadKeyToolStripMenuItem.Click += new System.EventHandler(this.LoadKeyToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(533, 356);
            this.panel1.TabIndex = 4;
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Location = new System.Drawing.Point(0, 0);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(533, 356);
            this.textBox1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 402);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem GenerateKeyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SavePrivateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SavePublicToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem LoadKeyToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox1;
    }
}

