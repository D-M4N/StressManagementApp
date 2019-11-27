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
    public partial class LogInArea : ContentPage
    {
        public LogInArea()
        {
            InitializeComponent();
        }

        private void OnLogin_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Contents());
        }
    }
}