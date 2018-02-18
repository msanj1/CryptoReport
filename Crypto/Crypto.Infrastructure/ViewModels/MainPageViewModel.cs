using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using Crypto.Infrastructure.Repositories;

namespace Crypto.Infrastructure.ViewModels
{
    public class MainPageViewModel : INotifyPropertyChanged
    {
        private readonly CoinRepository _coinRepository;

        public MainPageViewModel(CoinRepository coinRepository)
        {
            _coinRepository = coinRepository;
        }


        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
