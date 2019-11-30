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
    public partial class ForgetPassWordScreen : ContentPage
    {
        public ForgetPassWordScreen()
        {
            InitializeComponent();
        }
        private async void RequestCode_Button(object sender, EventArgs e)
        {
            await DisplayAlert("Verification Code Sent To Your Number", "Please check Your Messages", "Thank You");
          
        }

        private async void SubmitCode_Button(object sender, EventArgs e)
        {
            await DisplayAlert("Verification Code Accepted", "Your User Name And PassWord Has Been Sent To Your E-mail Account ", "Now Head Back To The Login Screen");

        }

        private void OnLogin_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new LogInArea());
        }
    }
}