using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.Win32;
using System.Security.Cryptography;

using System.Configuration;

namespace LicenseShow_TrialCheck
{
    class Trial
    {
        public static Boolean checkTrial(out int daysLeft)
        {
            string trValR, trHashR, trValC, trHashC;

            trValR = getTrialValueFromReg(out trHashR);
            trValC = getTrialValueFromConfig(out trHashC);

            byte[] bytes = Encoding.UTF8.GetBytes(trValR);
            string hash = getSHA1Hash(bytes);

            bool trRegValid = trHashR == hash;

            bool trConfigValid = false;
            if (trValC != String.Empty && trHashC != String.Empty)
            {
                bytes = Encoding.UTF8.GetBytes(trValC);
                hash = getSHA1Hash(bytes);
                trConfigValid = trHashC == hash;
            }

            int trRegLeft = int.MinValue;
            if (trRegValid)
            {
                trRegLeft = getTrialDaysLeft(trValR);
            }

            int trConfigLeft = int.MinValue;
            if (trConfigValid)
            {
                trConfigLeft = getTrialDaysLeft(trValC);
            }

            daysLeft = int.MinValue;

            if (trConfigValid && inTrialInterval(trConfigLeft))
            {
                daysLeft = trConfigLeft;
            }

            if (trRegValid && inTrialInterval(trRegLeft))
            {
                if (daysLeft < trRegLeft)
                    daysLeft = trRegLeft;
            }

            return inTrialInterval(daysLeft);
        }

        private static bool inTrialInterval(int daysLeft)
        {
            return (daysLeft > 0) && (daysLeft <= TRIAL_LENGTH);
        }

        private static int getTrialDaysLeft(string trStartDate)
        {
            DateTime sdt = DateTime.ParseExact(trStartDate, TR_DATE_FORMAT, null);
            DateTime cdt = DateTime.Now;
            TimeSpan d = cdt - sdt;

            return TRIAL_LENGTH - d.Days;
        }

        private static string getTrialValueFromReg(out string hash)
        {
            string s = String.Empty;
            hash = String.Empty;
            using (RegistryKey rk = Registry.CurrentUser.OpenSubKey(AppConst.KEY_NAME_SHORT))
            {
                if (rk != null)
                {
                    s = (string)rk.GetValue(AppConst.TRIAL_KEY_DATA_NAME);
                    try
                    {
                        byte[] bytes = Convert.FromBase64String(s);
                        s = Encoding.UTF8.GetString(bytes);
                    }
                    catch (Exception)
                    {
                        s = String.Empty;
                    }

                    hash = (string)rk.GetValue(AppConst.TRIAL_KEY_HASH_NAME);
                }
            }
            return s;
        }

        private static string getSHA1Hash(byte[] bytes)
        {
            string hashCalc;
            using (SHA1Managed sha1 = new SHA1Managed())
            {
                byte[] hashBytes = sha1.ComputeHash(bytes);
                hashCalc = AppConst.HexStringFromBytes(hashBytes);
            }
            return hashCalc;
        }

        private static string getTrialValueFromConfig(out string hash)
        {

            string stdVal = String.Empty;

            hash = String.Empty;

            System.Configuration.Configuration configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            if (configuration.HasFile)
            {
                //configuration.AppSettings.Settings[AppConst.TRIAL_KEY_NAME].Value = "1";
                stdVal = configuration.AppSettings.Settings[AppConst.TRIAL_KEY_DATA_NAME].Value;
                try
                {
                    byte[] bytes = Convert.FromBase64String(stdVal);
                    stdVal = Encoding.UTF8.GetString(bytes);
                }
                catch (Exception e)
                {
                    stdVal = String.Empty;
                }

                hash = configuration.AppSettings.Settings[AppConst.TRIAL_KEY_HASH_NAME].Value;
            }

            return stdVal;
        }

        public static Boolean setTrial()
        {
            setTrialToRegistry();
            setTrialToConfig();
            return true;
        }

        private static void setTrialToRegistry()
        {
            string stdVal, stdHash;

            stdVal = getTrialInitInfo(out stdHash);

            Registry.SetValue(AppConst.KEY_NAME, AppConst.TRIAL_KEY_NAME, 1);
            Registry.SetValue(AppConst.KEY_NAME, AppConst.TRIAL_KEY_DATA_NAME, stdVal);
            Registry.SetValue(AppConst.KEY_NAME, AppConst.TRIAL_KEY_HASH_NAME, stdHash);

        }

        /// <summary>
        /// http://stackoverflow.com/questions/13130620/cannot-write-settings-on-app-config-or-no-changes-are-shown
        /// 
        ///I think what is happening is that you are testing in Visual Studio, 
        ///it copys the App.Config to your Debug/Release directory and renames it YourApplication.vshost.exe.config 
        ///which gets reset each time you start your application. Try running the executable outside of Visual Studio 
        ///which will use the YourApplication.exe.config file and see if that works for you. 
        ///Your Code is working for me and retaining your changes on application restart if I run it outside of Visual Studio.
        /// </summary>
        private static void setTrialToConfig()
        {
            string stdVal, stdHash;

            stdVal = getTrialInitInfo(out stdHash);

            System.Configuration.Configuration configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            if (configuration.HasFile)
            {
                ///добавляет значения через запятую
                //configuration.AppSettings.Settings.Add(AppConst.TRIAL_KEY_NAME, "1");
                //configuration.AppSettings.Settings.Add(AppConst.TRIAL_KEY_DATA_NAME, stdVal);
                //configuration.AppSettings.Settings.Add(AppConst.TRIAL_KEY_HASH_NAME, stdHash);

                //перезаписывает значения в конфиге
                configuration.AppSettings.Settings[AppConst.TRIAL_KEY_NAME].Value = "1";
                configuration.AppSettings.Settings[AppConst.TRIAL_KEY_DATA_NAME].Value = stdVal;
                configuration.AppSettings.Settings[AppConst.TRIAL_KEY_HASH_NAME].Value = stdHash;

                configuration.Save();

                ConfigurationManager.RefreshSection("appSettings");
            }

        }

        /// <summary>
        /// Return info for trial start
        /// </summary>
        /// <param name="hash">out param. return hash of result string</param>
        /// <returns>current date in base64 format and sha1 hash</returns>
        private static string getTrialInitInfo(out string hash)
        {
            string date = DateTime.Now.ToString(TR_DATE_FORMAT);

            var bytes = Encoding.UTF8.GetBytes(date);

            hash = getSHA1Hash(bytes);

            string s = Convert.ToBase64String(bytes);

            return s;
        }

        private const string TR_DATE_FORMAT = "yyyy.MM.dd";
        private const int TRIAL_LENGTH = 30; //days
    }
}
