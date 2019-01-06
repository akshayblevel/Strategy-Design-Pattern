using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    class MD5Hash : HashingStrategy
    {
        public override string GenerateHash(string text)
        {
            MD5 md5 = new MD5CryptoServiceProvider();

            Byte[] bytes;
            bytes = ASCIIEncoding.Default.GetBytes(text);

            Byte[] encodedBytes;
            encodedBytes = md5.ComputeHash(bytes);

            return BitConverter.ToString(encodedBytes);
        }
    }
}
