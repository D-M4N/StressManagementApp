using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
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
            var JokeGenerator = new JokeGenerator();
            string joke = await JokeGenerator.GetRandomJoke();

            JokeLabel.Text = joke;

        }

        private void ChuckVsAb(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri("http://youtube.com/watch?v=zj2Zf9tlg2Y"));
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