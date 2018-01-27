using Crypto.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Crypto.Core.Entities;
using Crypto.Interfaces;
using Xamarin.Forms;

namespace Crypto
{
	public partial class MainPage : ContentPage
	{
	    string translatedNumber;

        public MainPage()
		{
			InitializeComponent();
		}

	    private void TranslateButton_OnClicked(object sender, EventArgs e)
	    {
	        translatedNumber = PhonewordTranslator.ToNumber(phoneNumberText.Text);
	        if (!string.IsNullOrWhiteSpace(translatedNumber))
	        {
	            callButton.IsEnabled = true;
	            callButton.Text = "Call " + translatedNumber;
	        }
	        else
	        {
	            callButton.IsEnabled = false;
	            callButton.Text = "Call";
	        }
        }

	    private async void CallButton_OnClicked(object sender, EventArgs e)
	    {
	        if (await this.DisplayAlert(
	            "Dial a Number","Would you like to call "+ translatedNumber + "?","Yes","No"))
	        {
	            var dialer = DependencyService.Get<IDialer>();
	            if (dialer != null)
	            {
	                App.PhoneNumbers.Add(new CallHistory(){ PhoneNumber= translatedNumber });
	                callHistoryButton.IsEnabled = true;
                    dialer.Dial(translatedNumber);
                }
	        }
	    }

	    private async void CallHistoryButton_OnClicked(object sender, EventArgs e)
	    {
	        await Navigation.PushAsync(new CallHistoryPage());
	    }
	}
}
