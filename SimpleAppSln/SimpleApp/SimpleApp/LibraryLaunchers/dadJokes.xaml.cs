using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SimpleApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class dadJokes : ContentPage
    {
        public dadJokes()
        {
            InitializeComponent();
        }

        private async void GagButton_Clicked(object sender, EventArgs e)
        {
            var GagGenerator = new GagGenerator();

            string jokeString = await GagGenerator.GetRandomJoke();

            GagLabel.Text = jokeString;
        }



        private void Like(object sender, EventArgs e)
        {
            Navigation.PushAsync(new LikeUsPlease());
        }
    }
}