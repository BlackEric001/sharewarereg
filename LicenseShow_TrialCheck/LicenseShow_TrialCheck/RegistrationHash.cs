using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Security.Cryptography;

namespace LicenseShow_TrialCheck
{
    class RegistrationHash: Registration
    {
        protected sealed override int getAppRegistrationType()
        {
            return APP_REGISTERED_HASH;
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

        public override Boolean keyValid(string regName, string regKey)
        {
            return (!keyInBlackList(regKey)) && (regName != String.Empty) && (regKey != String.Empty) && (regKey == gKey(regName));
        }

        private const int APP_REGISTERED_HASH = 128;

    }
}
