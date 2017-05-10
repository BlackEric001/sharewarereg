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
            System.Diagnostics.Process.Start("https://github.com/BlackEric001");
        }

        private void btnRegisterRSAKey_Click(object sender, EventArgs e)
        {
            string regName = textBoxName.Text;
            string regKey = textBoxKey.Text;

            registration = new RegistrationAsymmetric();

            if (registration.keyValid(regName, regKey))
            {
                registration.registerApp(regName, regKey);
                MessageBox.Show("Program registered. Thank you", "Attention!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Key Invalid!", "Attention!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnRegisterHaskKey_Click(object sender, EventArgs e)
        {
            string regName = textBoxName.Text;
            string regKey = textBoxKey.Text;

            registration = new RegistrationHash();

            if (registration.keyValid(regName, regKey))
            {
                registration.registerApp(regName, regKey);
                MessageBox.Show("Program registered. Thank you", "Attention!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Key Invalid!", "Attention!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        Registration registration;

    }
}
