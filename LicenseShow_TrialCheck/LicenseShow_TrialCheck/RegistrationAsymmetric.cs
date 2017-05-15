using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Security.Cryptography;

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
            return (!keyInBlackList(regKey)) && (regName != String.Empty) && (regKey != String.Empty) && verifyKey(regName, regKey);
        }

        private Boolean verifyKey(string regName, string regKey)
        {
            RSACryptoServiceProvider rsp = new RSACryptoServiceProvider(3072);
            try
            {
                /// В реальном приложении, для любителей патчить бинарник, можно проверять хеш зашитого в программу публичного ключа
                /// парой алгоритмов и в разных местах
                rsp.FromXmlString(Properties.Resources.PubKey);

                return rsp.VerifyData(stringToBytes(regName), new SHA1CryptoServiceProvider(), HexStringToBytes(regKey));

            }catch(Exception)
            {
                return false;
            }
            finally
            {
                rsp.Dispose();
            }
        }

        private static byte[] stringToBytes(string name)
        {
            ASCIIEncoding byteConverter = new ASCIIEncoding();
            byte[] originalData = byteConverter.GetBytes(name);
            return originalData;
        }

        /// <summary>
        /// Convert Hex String to Byte Array
        /// </summary>
        /// <param name="hex"></param>
        /// <returns></returns>
        public static byte[] HexStringToBytes(string hex)
        {
            if (hex.Length % 2 == 1)
                throw new Exception("The binary key cannot have an odd number of digits");

            byte[] arr = new byte[hex.Length >> 1];

            for (int i = 0; i < hex.Length >> 1; ++i)
            {
                arr[i] = (byte)((GetHexVal(hex[i << 1]) << 4) + (GetHexVal(hex[(i << 1) + 1])));
            }

            return arr;
        }

        /// <summary>
        /// Read function body carefully. 
        /// Now it works only for lowercase hex string
        /// </summary>
        /// <param name="hex"></param>
        /// <returns></returns>
        public static int GetHexVal(char hex)
        {
            int val = (int)hex;
            //For uppercase A-F letters:
            //return val - (val < 58 ? 48 : 55);
            //For lowercase a-f letters:
            return val - (val < 58 ? 48 : 87);
            //Or the two combined, but a bit slower:
            //return val - (val < 58 ? 48 : (val < 97 ? 55 : 87));
        }



        private const int APP_REGISTERED_RSA = 256;
    }
}
