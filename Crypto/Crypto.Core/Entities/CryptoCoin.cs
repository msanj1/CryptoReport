using System;
using System.Collections.Generic;
using System.Text;

namespace Crypto.Core.Entities
{
    public class CryptoCoin
    {
        public string CoinNameShort { get; set; }
        public string CoinNameFullName { get; set; }
        public double Price { get; set; }
        public double Growth24HrPercentage { get; set; }
    }
}
