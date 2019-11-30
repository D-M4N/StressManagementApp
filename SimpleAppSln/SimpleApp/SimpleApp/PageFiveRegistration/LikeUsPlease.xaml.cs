using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NAudio;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Newtonsoft.Json;
using System.Net.Http;
using Xamarin.Essentials;

namespace SimpleApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LikeUsPlease : ContentPage
    {
        public LikeUsPlease()
        {
            InitializeComponent();
        }

        private async void SmartApp(object sender, EventArgs e)
        {
            var current = Connectivity.NetworkAccess;

            if (current == NetworkAccess.Internet)
            {
                //When No Internet Access
                Device.OpenUri(new Uri("https://play.google.com/store/apps/details?id=net.rention.smarter&hl=en"));
            }
            else
            {
                //Display
                await DisplayAlert("CHECK YOUR DATA", "Please check internet connection", "Retry");
            }
        }

        private void Register_Button(object sender, EventArgs e)
        {
            Navigation.PushAsync(new RegistrationPage());
        }

        private async void HQ_Button(object sender, EventArgs e)



        // public async Task NavigateToBuilding25()
        {
            /*
             * 
            var placemark = new Placemark
            {
                CountryName = "South Africa",
                AdminArea = "SA",
                Thoroughfare = "Robben Island, 7400",
                Locality = "Robben Island"
            };
            var options = new MapLaunchOptions { Name = "The Cedars Avenue 28" };

            await Map.OpenAsync(placemark, options);

             */

            var current = Connectivity.NetworkAccess;

            if (current == NetworkAccess.Internet)
            {
                //When No Internet Access
                var placemark = new Placemark
                {
                    CountryName = "South Africa",
                    AdminArea = "SA",
                    Thoroughfare = "Robben Island, 7400",
                    Locality = "Robben Island"
                };
                var options = new MapLaunchOptions { Name = "The Cedars Avenue 28" };

                await Map.OpenAsync(placemark, options);
            }
            else
            {
                //Display
                await DisplayAlert("CHECK YOUR DATA", "Please check internet connection", "Retry");
            }
        }
    }
}