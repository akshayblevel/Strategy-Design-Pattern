using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    class SHA256Hash : HashingStrategy
    {
        public override string GenerateHash(string text)
        {
            SHA256 sha256 = new SHA256CryptoServiceProvider();

            Byte[] bytes;
            bytes = ASCIIEncoding.Default.GetBytes(text);

            Byte[] encodedBytes;
            encodedBytes = sha256.ComputeHash(bytes);

            return BitConverter.ToString(encodedBytes);
        }
    }
}
