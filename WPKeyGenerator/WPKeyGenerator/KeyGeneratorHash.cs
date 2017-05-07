using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Security.Cryptography;

namespace WPKeyGenerator
{
    class KeyGeneratorHash: KeyGenerator
    {
        public static string generateKey(string name)
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
                hashCalc = HexStringFromBytes(hashBytes);
            }
            return hashCalc;
        }

        public static Boolean validateKey(string name, string key)
        {
            return (name != String.Empty) && (key != String.Empty) && (key == generateKey(name));
        }

    }
}
