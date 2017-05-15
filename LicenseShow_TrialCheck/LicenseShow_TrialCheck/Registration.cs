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
            blackKeysList.Add("491c3631af8118d7d83ac5c2177a660b6041663a1be17cca9fbdadcd27e71e2303f4e198ea9b65647460f501bddac888805e2e848b06fb4093234cfb4817225d7d4c91a173fb3968d8efe7855cc928a960227e863badcfbba23f9b74415948a9da11d7b619707eae9fe4c0be5da5c5276a34ae97b5bfb5af0e61ddb95b9b607a1321ecd0b32d7b089bc0a9b253589a744fe8097aaddb3ed7d714806f7803726a7c1e9bf2776200bd3c8686f48b9483b60b3135e83f2f27492ee80f0de77c55b829f64d8d50221182da84afbdfafeaa5662173a3733268e866c2b8efce5ea4de36253d1fd0f6de90414354b1ce89130746922ecb99e9ac3c81e029f58f14ff3b00acb8db496b5a072d642c551749128fd0913930b39bcafec21ff509323431da647629b9d6bbc7e27de267fd21f324ed116217bdf8c6b990715b2f7d813e230651b6d138a9aea7c9a77108ed9000ff7ebc2c64a53d431eec69f2c7f7a4226220b7c05b20450974e2fa9da0b0a2503db34719180ba9bf171840518fc70e5934eb0");//qaz async
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
        /// Search key for registration in Black Key List
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
