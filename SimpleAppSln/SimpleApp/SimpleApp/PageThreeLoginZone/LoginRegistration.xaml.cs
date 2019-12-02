using SimpleApp.Registration;
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
    public partial class LoginRegistration : ContentPage
    {
        public LoginRegistration()
        {
            InitializeComponent();
        }
       
        private async void ConfirmButton_Clicked(object sender, EventArgs e)
        {
            await DisplayAlert("SIGN UP CONFIRMED", "Please Proceed Back To The Login Screen", "Thank You");
        }

        private void LoginButton_Clicked(object sender, EventArgs e)
        {
                   
            Navigation.PushAsync(new LogInArea());

        }

    }
}