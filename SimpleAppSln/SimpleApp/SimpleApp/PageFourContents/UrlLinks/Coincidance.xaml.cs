using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SimpleApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Coincidance : ContentPage
    {
        public Coincidance()
        {
            InitializeComponent();
        }

        private async void WebDance(object sender, EventArgs e)
        {
            
            var current = Connectivity.NetworkAccess;

            if (current == NetworkAccess.Internet)
            {
                //When No Internet Access
                Device.OpenUri(new Uri("https://www.youtube.com/watch?v=nBHkIWAJitg"));
            }
            else
            {
                //Display
                await DisplayAlert("CHECK YOUR DATA", "Please check internet connection", "Retry");
            }
        }

        private void Like(object sender, EventArgs e)
        {
            Navigation.PushAsync(new LikeUsPlease());
        }
    }
}