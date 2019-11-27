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
    public partial class Coincidance : ContentPage
    {
        public Coincidance()
        {
            InitializeComponent();
        }

        private void WebDance(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri("https://www.youtube.com/watch?v=nBHkIWAJitg"));
        }

        private void Like(object sender, EventArgs e)
        {
            Navigation.PushAsync(new LikeUsPlease());
        }
    }
}