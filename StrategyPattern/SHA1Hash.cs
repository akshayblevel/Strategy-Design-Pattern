using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    class SHA1Hash : HashingStrategy
    {
        public override string GenerateHash(string text)
        {
            SHA1 sha1 = new SHA1CryptoServiceProvider();

            Byte[] bytes;
            bytes = ASCIIEncoding.Default.GetBytes(text);

            Byte[] encodedBytes;
            encodedBytes = sha1.ComputeHash(bytes);

            return BitConverter.ToString(encodedBytes);
        }
    }
}
