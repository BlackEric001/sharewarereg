using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Security.Cryptography;

namespace WPKeyGenerator
{
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
            ASCIIEncoding byteConverter = new ASCIIEncoding();
            byte[] originalData = byteConverter.GetBytes(name);
            return HexStringFromBytes(rsp.SignData(originalData, new SHA1CryptoServiceProvider()));
        }

        public override Boolean validateKey(string name, string key)
        {
            return (name != String.Empty) && (key != String.Empty) && (key == generateKey(name));
        }

        RSACryptoServiceProvider rsp;
    }
}
