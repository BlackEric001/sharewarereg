using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Security.Cryptography;

namespace WPKeyGenerator
{
    /// <summary>
    /// https://msdn.microsoft.com/en-us/library/9tsc5d0z(v=vs.110).aspx
    /// </summary>
    class KeyGeneratorAsymmetric: KeyGenerator
    {

        public KeyGeneratorAsymmetric(string rsaKey)
        {
            rsp = new RSACryptoServiceProvider();
            rsp.FromXmlString(rsaKey);
        }

        ~KeyGeneratorAsymmetric()
        {
            rsp.Dispose();
        }

        public Boolean publicOnly{ get {return rsp.PublicOnly;}}

        public override string generateKey(string name)
        {
            return HexStringFromBytes(rsp.SignData(stringToBytes(name), new SHA1CryptoServiceProvider()));
        }

        public override Boolean validateKey(string name, string key)
        {
            //return (name != String.Empty) && (key != String.Empty) && (key == generateKey(name));

            return rsp.VerifyData(stringToBytes(name), new SHA1CryptoServiceProvider(), HexStringToBytes(key));
        }

        private static byte[] stringToBytes(string name)
        {
            ASCIIEncoding byteConverter = new ASCIIEncoding();
            byte[] originalData = byteConverter.GetBytes(name);
            return originalData;
        }

        RSACryptoServiceProvider rsp;
    }
}
