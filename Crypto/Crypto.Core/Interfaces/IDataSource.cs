using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Crypto.Core.Entities;

namespace Crypto.Core.Interfaces
{
    public interface IDataSource
    {
        Task<List<CryptoCoin>> GetCoinsAsync();
    }
}
