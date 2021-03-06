﻿using Newtonsoft.Json;
using RassavadaNew.API;
using RassavadaNew.Home;
using RassavadaNew.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RassavadaNew.AuthPages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class VerificationPage : ContentPage
    {
        public VerificationPage(string name,string email,string path)
        {
            InitializeComponent();
            NameLabel.Text = name;
            EmailLabel.Text = email;
            ImageLabel.Source = path;

            //Type type = Type.GetType(returnResponseText);
            //object oClass = Activator.CreateInstance(type);
            
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            App.Current.MainPage = new NavigationPage(new HomePage());
            await Navigation.PopToRootAsync();
                
        }

        private async void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}