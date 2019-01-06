using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    class SHA384Hash : HashingStrategy
    {
        public override string GenerateHash(string text)
        {
            SHA384 sha384 = new SHA384CryptoServiceProvider();

            Byte[] bytes;
            bytes = ASCIIEncoding.Default.GetBytes(text);

            Byte[] encodedBytes;
            encodedBytes = sha384.ComputeHash(bytes);

            return BitConverter.ToString(encodedBytes);
        }
    }
}
