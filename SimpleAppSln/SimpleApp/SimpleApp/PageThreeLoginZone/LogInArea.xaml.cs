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
    public partial class LogInArea : ContentPage
    {
        public LogInArea()
        {
            InitializeComponent();
        }

        public class LoginViewModel : INotifyPropertyChanged
        {
            public Action DisplayInvalidLoginPrompt;

            public event PropertyChangedEventHandler PropertyChanged = delegate { };

            private string username;
            public string UserName
            {
                get { return username; }
                set
                {
                    username = value;
                    PropertyChanged(this, new PropertyChangedEventArgs("UserName"));
                }
            }
            private string password;
            public string PassWord
            {
                get { return password; }
                set
                {
                    password = value;
                    PropertyChanged(this, new PropertyChangedEventArgs("PassWord"));
                }
            }


            public ICommand LoginCommand { protected set; get; }

            public LoginViewModel()
            {
                LoginCommand = new Command(Login);
            }
            public void Login()
            {
                if (username != "madmax" || password != "secret")
                {
                    DisplayInvalidLoginPrompt();
                }
            }
        }
        
        private void OnLogin_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Contents());
        }
        
        private void OnForgotPassWord_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ForgetPassWordScreen());
        }

        private void OnSignUp_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new LoginRegistration());
        }
    }
}