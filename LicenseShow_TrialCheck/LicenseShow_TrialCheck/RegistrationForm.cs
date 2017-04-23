using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LicenseShow_TrialCheck
{
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Specify that the link was visited.
            this.linkLabel1.LinkVisited = true;

            // Navigate to a URL.
            System.Diagnostics.Process.Start("http://www.microsoft.com");
        }

        private void btn_Register_Click(object sender, EventArgs e)
        {
            string regName = textBoxName.Text;
            string regKey = textBoxKey.Text;
            if (Registration.keyValid(regName, regKey))
            {
                Registration.registerApp(regName, regKey);
                MessageBox.Show("Program registered. Thank you", "Attention!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Key Invalid!", "Attention!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
