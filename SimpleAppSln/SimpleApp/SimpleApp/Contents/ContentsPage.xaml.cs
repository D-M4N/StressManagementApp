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
    public partial class Contents : ContentPage
    {
        public Contents()
        {
            InitializeComponent();
        }

        private void Chuck(object sender, EventArgs e)
        {
            Navigation.PushAsync(new chuckJokes());
        }

        private void Dad(object sender, EventArgs e)
        {
            Navigation.PushAsync(new dadJokes());
        }

        private void Dancing(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Coincidance());
        }

        private void Angry(object sender, EventArgs e)
        {
            Navigation.PushAsync(new AngerManagement());
        }




    }
}