using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    class HashingContext
    {
        private HashingStrategy _hashingStrategy;

        public HashingContext(HashingStrategy hashingStrategy)
        {
            _hashingStrategy = hashingStrategy;
        }

        public string HashPassword(string text)
        {
            return _hashingStrategy.GenerateHash(text);
        }
    }
}
