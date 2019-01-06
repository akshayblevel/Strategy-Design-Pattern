using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    public abstract class HashingStrategy
    {
        public abstract string GenerateHash(string text);
    }
}
