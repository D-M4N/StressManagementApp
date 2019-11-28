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
    public partial class AngerManagement : ContentPage
    {
        public AngerManagement()
        {
            InitializeComponent();
        }

        private void WebAnger(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri("https://www.youtube.com/watch?v=NkRkuI0ZgX0"));
        }

        private void WebApp(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri("https://play.google.com/store/apps/details?id=com.getsomeheadspace.android&hl=en"));
        }

        private void Like(object sender, EventArgs e)
        {
            Navigation.PushAsync(new LikeUsPlease());
        }

       
    }


}