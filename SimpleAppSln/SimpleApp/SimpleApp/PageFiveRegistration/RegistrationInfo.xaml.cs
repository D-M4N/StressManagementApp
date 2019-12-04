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
    }
}