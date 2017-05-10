using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LicenseShow_TrialCheck
{
    class RegistrationAsymmetric: Registration
    {
        protected sealed override int getAppRegistrationType()
        {
            return APP_REGISTERED_RSA;
        }

        public override Boolean keyValid(string regName, string regKey)
        {
            return (!keyInBlackList(regKey)) && (regName != String.Empty) && (regKey != String.Empty) && (regKey == gKey(regName));
        }

        public static string gKey(string name)
        {
            return "";
        }

        private const int APP_REGISTERED_RSA = 256;
    }
}
