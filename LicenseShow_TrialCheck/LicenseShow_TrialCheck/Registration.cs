using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.Win32;
using System.Security.Cryptography;

namespace LicenseShow_TrialCheck
{
    class Registration
    {
        public static Boolean isRegistered()
        {
            Boolean res = false;

            using (RegistryKey rk = Registry.CurrentUser.OpenSubKey(AppConst.KEY_NAME_SHORT))
            {
                if (rk != null)
                {
                    if ((int)rk.GetValue(AppConst.TRIAL_KEY_NAME) == APP_REGISTERED)
                    {
                        string regName = (string)rk.GetValue(AppConst.TRIAL_KEY_DATA_NAME);
                        string regKey = (string)rk.GetValue(AppConst.TRIAL_KEY_HASH_NAME);

                        if ((regName != String.Empty) && (regKey != String.Empty))
                            res = keyValid(regName, regKey);
                    }
                }
            }
            return res;
        }

        public static void registerApp(string regName, string regKey)
        {
            Registry.SetValue(AppConst.KEY_NAME, AppConst.TRIAL_KEY_NAME, APP_REGISTERED);
            Registry.SetValue(AppConst.KEY_NAME, AppConst.TRIAL_KEY_DATA_NAME, regName);
            Registry.SetValue(AppConst.KEY_NAME, AppConst.TRIAL_KEY_HASH_NAME, regKey);
        }

        public static Boolean keyValid(string regName, string regKey)
        {
            return (!keyInBlackList(regKey))&&(regName != String.Empty) && (regKey != String.Empty) && (regKey == gKey(regName));
        }

        public static string gKey(string name)
        {
            name += "$" + name;

            return getSHA256Hash(Encoding.UTF8.GetBytes(name));
        }

        private static string getSHA256Hash(byte[] bytes)
        {
            string hashCalc;
            using (SHA256Managed sha = new SHA256Managed())
            {
                byte[] hashBytes = sha.ComputeHash(bytes);
                hashCalc = AppConst.HexStringFromBytes(hashBytes);
            }
            return hashCalc;
        }

        /// <summary>
        /// Black Key List
        /// </summary>
        /// param name="key"
        /// <returns></returns>
        private static Boolean keyInBlackList(string key)
        {
            List<string> list = new List<string>();
            list.Add("8cabb317180b40d1179c11e6cee09d5557bb390b6dcecc31ab950ed4ecfce12e"); //a
            list.Add("6ebb2d298fd6e6184e39b25a0dc3399e47c459faf178e8cea8a512fb41cef40e"); //b
            list.Add("ec1784b6ecac44230d31c2d74cb79c6817bdd82090bdba95f361ae39d588aa7d"); //c

            return key == list.Find(v => v == key);
        }


        private const int APP_REGISTERED = 128;

    }
}
