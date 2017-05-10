using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.Win32;
//using System.Security.Cryptography;

namespace LicenseShow_TrialCheck
{
    class Registration
    {

        public Registration()
        {
            blackKeysList = new List<string>();
            blackKeysList.Add("8cabb317180b40d1179c11e6cee09d5557bb390b6dcecc31ab950ed4ecfce12e"); //a
            blackKeysList.Add("6ebb2d298fd6e6184e39b25a0dc3399e47c459faf178e8cea8a512fb41cef40e"); //b
            blackKeysList.Add("ec1784b6ecac44230d31c2d74cb79c6817bdd82090bdba95f361ae39d588aa7d"); //c
        }

        /// <summary>
        /// This method must to be overrided in inherited classes
        /// </summary>
        /// <returns></returns>
        protected virtual int getAppRegistrationType()
        {
            return -1;
        }

        /// <summary>
        /// This method must to be overrided in inherited classes
        /// </summary>
        /// <param name="regName"></param>
        /// <param name="regKey"></param>
        /// <returns></returns>
        public virtual Boolean keyValid(string regName, string regKey)
        {
            return false;
        }

        public Boolean isRegistered()
        {
            Boolean res = false;

            using (RegistryKey rk = Registry.CurrentUser.OpenSubKey(AppConst.KEY_NAME_SHORT))
            {
                if (rk != null)
                {
                    if ((int)rk.GetValue(AppConst.TRIAL_KEY_NAME) == this.getAppRegistrationType())
                    {
                        string regName = (string)rk.GetValue(AppConst.TRIAL_KEY_DATA_NAME);
                        string regKey = (string)rk.GetValue(AppConst.TRIAL_KEY_HASH_NAME);

                        if ((regName != String.Empty) && (regKey != String.Empty))
                            res = this.keyValid(regName, regKey);
                    }
                }
            }
            return res;
        }

        public void registerApp(string regName, string regKey)
        {
            Registry.SetValue(AppConst.KEY_NAME, AppConst.TRIAL_KEY_NAME, this.getAppRegistrationType());
            Registry.SetValue(AppConst.KEY_NAME, AppConst.TRIAL_KEY_DATA_NAME, regName);
            Registry.SetValue(AppConst.KEY_NAME, AppConst.TRIAL_KEY_HASH_NAME, regKey);
        }

        /// <summary>
        /// Black Key List
        /// </summary>
        /// param name="key"
        /// <returns></returns>
        protected static Boolean keyInBlackList(string key)
        {
            return key == blackKeysList.Find(v => v == key);
        }

        private static List<string> blackKeysList;

    }
}
