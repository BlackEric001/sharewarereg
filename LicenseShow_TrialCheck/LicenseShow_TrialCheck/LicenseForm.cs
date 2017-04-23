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
    public partial class LicenseForm : Form
    {
        public LicenseForm()
        {
            InitializeComponent();
        }

        private void btn_Accept_Click(object sender, EventArgs e)
        {
            License.licenseAccepted();
            Trial.setTrial();
            this.Close();
        }

        private void btn_Decline_Click(object sender, EventArgs e)
        {
            this.Close();

            licenseDeclineAction();
        }

        private void LicenseForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing && !License.isLicenseAccepted())
            {
                licenseDeclineAction();
            }
        }

        private void licenseDeclineAction()
        {
            MessageBox.Show("License not accepted! Program will be closed", "Attention!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Application.Exit();
        }
    }
}
