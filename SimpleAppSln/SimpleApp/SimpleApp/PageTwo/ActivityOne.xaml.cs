﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SimpleApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ActivityOne : ContentPage
    {

        public ActivityOne()
        {
            InitializeComponent();

            
        }

        private void SessionStart(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Contents());
        }

    }
}