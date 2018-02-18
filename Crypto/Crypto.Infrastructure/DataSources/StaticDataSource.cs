using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Crypto.Core.Entities;
using Crypto.Core.Interfaces;

namespace Crypto.Infrastructure.DataSources
{
    public class StaticDataSource : IDataSource
    {
        private readonly List<CryptoCoin> _coins;
        public StaticDataSource()
        {
            _coins = new List<CryptoCoin>();
            CryptoCoin coin1 = new CryptoCoin(){CoinNameFullName="Bitcoin",CoinNameShort="BTC",Growth24HrPercentage=-2.27,Price=10465.21};
            CryptoCoin coin2 = new CryptoCoin() { CoinNameFullName = "Ethereum", CoinNameShort = "ETH", Growth24HrPercentage = -2.87, Price = 924.94 };
            CryptoCoin coin3 = new CryptoCoin() { CoinNameFullName = "Ripple", CoinNameShort = "XRPO", Growth24HrPercentage = -3.03, Price = 1.09577 };
            CryptoCoin coin4 = new CryptoCoin() { CoinNameFullName = "Bitcoin Cash", CoinNameShort = "BCH", Growth24HrPercentage = -5.36, Price = 1456.8 };
            CryptoCoin coin5 = new CryptoCoin() { CoinNameFullName = "Litecoin", CoinNameShort = "LTC", Growth24HrPercentage = -4.82, Price = 218.5 };
            CryptoCoin coin6 = new CryptoCoin() { CoinNameFullName = "Samsara Coin", CoinNameShort = "SMSR", Growth24HrPercentage = 0.0, Price = 0.007611 };
            _coins.Add(coin1);
            _coins.Add(coin2);
            _coins.Add(coin3);
            _coins.Add(coin4);
            _coins.Add(coin5);
            _coins.Add(coin6);
        }
        public Task<List<CryptoCoin>> GetCoinsAsync()
        {
            return Task.FromResult(_coins);
        }
    }
}
