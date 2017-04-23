using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.Win32;

namespace LicenseShow_TrialCheck
{
    class License
    {

        public static Boolean isLicenseAccepted()
        {
            string res = (string) Registry.GetValue(AppConst.KEY_NAME, AppConst.LIC_KEY_NAME, "");
            return res == AppConst.LIC_KEY_VALUE;

        }

        public static Boolean licenseAccepted()
        {
            Registry.SetValue(AppConst.KEY_NAME, AppConst.LIC_KEY_NAME, AppConst.LIC_KEY_VALUE);
            return true;
        }
    }
}
