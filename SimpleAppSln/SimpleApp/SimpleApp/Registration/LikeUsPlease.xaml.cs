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

        private void SmartApp(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri("https://play.google.com/store/apps/details?id=net.rention.smarter&hl=en"));
        }

        private void Register_Button(object sender, EventArgs e)
        {
            Navigation.PushAsync(new RegistrationPage());
        }

        private async void HQ_Button(object sender, EventArgs e)



        // public async Task NavigateToBuilding25()
        {
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


    }
}