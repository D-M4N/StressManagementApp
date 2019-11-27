using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SimpleApp.Registration
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RegistrationInfo : ContentPage
    {
        public List<InformationTable> Info { get; set; }
        public RegistrationInfo()
        {
            InitializeComponent();
        }

        
        protected override async void OnAppearing()
        {
            base.OnAppearing();
            var Database = App.Database;
            Info = await Database.GetItemsAsync();
            BindingContext = this;
        }

        /*
        private async void OnConfirmOrderClicked(object sender, EventArgs e)
        {
         
            var client = new HttpClient(new HttpClientHandler());
            var url = "https://10.0.2.2:5001/TshirtOrder";
            var Infotable = new InformationTable();
            var json = JsonConvert.SerializeObject(Infotable);
            var content = new StringContent(json, System.Text.Encoding.UTF8, "application/json");
            try
            {
                var response = await client.PostAsync(url, content);
                await DisplayAlert("Response Message", response.ReasonPhrase, "ok");
            }
            catch (Exception)
            {
                await DisplayAlert("Exceptions", "Try Again", "ok");
            }

            
        }
        
         */


    }


}