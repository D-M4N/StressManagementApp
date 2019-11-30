using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SimpleApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class chuckJokes : ContentPage
    {
        public chuckJokes()
        {
            InitializeComponent();
        }

        private async void JokeButton_Clicked(object sender, EventArgs e)
        {
           
            var current = Connectivity.NetworkAccess;

            if (current == NetworkAccess.Internet)
            {
                //When No Internet Access
                var JokeGenerator = new JokeGenerator();
                string joke = await JokeGenerator.GetRandomJoke();

                JokeLabel.Text = joke;
            }
            else
            {
                //Display
                await DisplayAlert("CHECK YOUR DATA", "Please check internet connection", "Retry");
            }

        }

        private async void ChuckVsAb(object sender, EventArgs e)
        {
           

            var current = Connectivity.NetworkAccess;

            if (current == NetworkAccess.Internet)
            {
                //When No Internet Access
                Device.OpenUri(new Uri("http://youtube.com/watch?v=zj2Zf9tlg2Y"));
            }
            else
            {
                //Display
                await DisplayAlert("CHECK YOUR DATA", "Please check internet connection", "Retry");
            }
        }

        private void ChuckInfo(object sender, EventArgs e)
        {
            Navigation.PushAsync(new AboutNorris());
        }


        private void Like(object sender, EventArgs e)
        {
            Navigation.PushAsync(new LikeUsPlease());
        }
    }
}