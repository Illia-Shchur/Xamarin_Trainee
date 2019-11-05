﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Collections.Generic;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace App3
{
    public partial class App : Application
    {
        public static List<string> Titles = new List<string>();
        public static List<string> Dates = new List<string>();

        public App()
        {

            InitializeComponent();

            MainPage = new NavigationPage(new MainPage());

        }

        protected override void OnStart()
        {
            
        }

        protected override void OnSleep()
        {
            
        }

        protected override void OnResume()
        {

        }
    }
}