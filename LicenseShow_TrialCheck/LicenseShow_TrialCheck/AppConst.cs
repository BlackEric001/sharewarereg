using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LicenseShow_TrialCheck
{
    static class AppConst
    {
        private const string COMPANY_NAME = "BlackEric001Test";
        public const string LIC_KEY_NAME = "License";
        public const string LIC_KEY_VALUE = "accept";
        public const string APP_NAME = "WP1";

        private const string REG_USER_ROOT = "HKEY_CURRENT_USER";
        public static readonly string KEY_NAME = REG_USER_ROOT + @"\software\" + COMPANY_NAME + @"\" + APP_NAME;
        public static readonly string KEY_NAME_SHORT = @"software\" + COMPANY_NAME + @"\" + APP_NAME;

        public const string TRIAL_KEY_NAME = "Tr";
        public const string TRIAL_KEY_DATA_NAME = "TRD";
        public const string TRIAL_KEY_HASH_NAME = "TRH";

        public const string REG_NAME = "REG_NAME";
        public const string REG_KEY  = "REG_KEY";

        /// <summary>
        /// Convert an array of bytes to a string of hex digits
        /// </summary>
        /// <param name="bytes">array of bytes</param>
        /// <returns>String of hex digits</returns>
        public static string HexStringFromBytes(byte[] bytes)
        {
            var sb = new StringBuilder();
            foreach (byte b in bytes)
            {
                var hex = b.ToString("x2");
                sb.Append(hex);
            }
            return sb.ToString();
        }

    }
}
