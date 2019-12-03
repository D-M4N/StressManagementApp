using SimpleApp.Registration;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
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

        public class LoginViewModel : INotifyPropertyChanged
        {
            public Action DisplayInvalidLoginPrompt;

            public event PropertyChangedEventHandler PropertyChanged = delegate { };

            private string email;
            public string Email
            {
                get { return email; }
                set
                {
                    email = value;
                    PropertyChanged(this, new PropertyChangedEventArgs("Email"));
                }
            }
            private string password;
            public string Password
            {
                get { return password; }
                set
                {
                    password = value;
                    PropertyChanged(this, new PropertyChangedEventArgs("Password"));
                }
            }
            public ICommand ConfirmCommand { protected set; get; }

            public LoginViewModel()
            {
                ConfirmCommand = new Command(Confirm);
            }
            public void Confirm()
            {
                if (email != "madmax@gmail.com" || password != "secret")
                {
                    DisplayInvalidLoginPrompt();
                }

            }
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






