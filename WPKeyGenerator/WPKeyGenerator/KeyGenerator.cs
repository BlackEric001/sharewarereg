using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Security.Cryptography;

namespace WPKeyGenerator
{
    class KeyGenerator
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



        public static Boolean validateKey(string name, string key)
        {

            return (name != String.Empty)&&(key != String.Empty)&&(key == generateKey(name));
        }

        /// <summary>
        /// Get Key data for save to file or copy to clipboard
        /// </summary>
        /// <param name="name"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public static string getDataForExport(string name, string key)
        {
            return name + Environment.NewLine + "================================================================================" + Environment.NewLine + key;
        }

    }
}
