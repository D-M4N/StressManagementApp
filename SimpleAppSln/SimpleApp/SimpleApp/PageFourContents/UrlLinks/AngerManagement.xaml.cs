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
    public partial class AngerManagement : ContentPage
    {
        public AngerManagement()
        {
            InitializeComponent();
        }

        private async void WebAnger(object sender, EventArgs e)
        {
            var current = Connectivity.NetworkAccess;

            if (current == NetworkAccess.Internet)
            {
                //When No Internet Access
                Device.OpenUri(new Uri("https://www.youtube.com/watch?v=NkRkuI0ZgX0"));
            }
            else
            {
                //Display
                await DisplayAlert("CHECK YOUR DATA", "Please check internet connection", "Retry");
            }

        }


        private async void WebApp(object sender, EventArgs e)
        {
           

            var current = Connectivity.NetworkAccess;

            if (current == NetworkAccess.Internet)
            {
                //When No Internet Access
                Device.OpenUri(new Uri("https://play.google.com/store/apps/details?id=com.getsomeheadspace.android&hl=en"));
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

        private void AngerStepsButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new AngerSteps());
        }


    }


}