using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Crypto.Core.Entities;
using Crypto.Core.Interfaces;

namespace Crypto.Infrastructure.Repositories
{
    public class CoinRepository
    {
        private readonly IDataSource _dataSource;

        public CoinRepository(IDataSource dataSource)
        {
            _dataSource = dataSource;
        }
        public Task<List<CryptoCoin>> GetTop10CoinsAsync()
        {
            return _dataSource.GetCoinsAsync();
        }
    }
}
