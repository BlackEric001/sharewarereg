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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            if (!License.isLicenseAccepted())
            {
                licenseShow();   
            }

            Registration registration = new RegistrationHash();

            if (!registration.isRegistered()) //если не зарегистрировано, то
            {
                int daysLeft = 0;
                if (!Trial.checkTrial(out daysLeft)) //проверяем триал
                {
                    disableInterface(); //если триал протух, то отключаем интерфейс
                    this.Text = AppConst.APP_NAME + ". Trial Expired " + daysLeft + " day(s) ago. Please register.";
                }
                this.Text = AppConst.APP_NAME + ". Trial left " + daysLeft + " day(s). Please register";
                showRegistrationForm(); //показываем форму регистрации вне зависимости от протухания триала

                if (registration.isRegistered())
                {
                    enableInterface(); //включаем интерфейс если зарегистрировались

                    this.Text = AppConst.APP_NAME;
                }

            }
            else
            {
                this.Text = AppConst.APP_NAME;
            }
        }


        private void disableInterface()
        {
            panel1.Enabled = false;
        }

        private void enableInterface()
        {
            panel1.Enabled = true;
        }

        private void showRegistrationForm()
        {
            using(RegistrationForm rf = new RegistrationForm()){
                rf.ShowDialog(this);
            }
        }

        private void licenseShow()
        {
            LicenseForm lf = new LicenseForm();
            try
            {
                lf.ShowDialog(this);
            }
            finally
            {
                lf.Dispose();
            }
        }

        private void btn_ShowLicense_Click(object sender, EventArgs e)
        {
            licenseShow();
        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            showRegistrationForm();
        }
    }
}
