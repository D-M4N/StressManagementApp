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
    public partial class RegistrationPage : ContentPage
    {
        public RegistrationPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            var infotable = new InformationTable();

            BindingContext = infotable;
        }



        private async void OnSave_Clicked(object sender, EventArgs e)
        {
            var informationtTable = (InformationTable)BindingContext;
            await App.Database.SaveItemAsync(informationtTable);

        }

        private void OnRegister_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new RegistrationInfo());
        }

    
    }
}