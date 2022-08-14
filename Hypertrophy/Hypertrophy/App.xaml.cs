﻿using Hypertrophy.Pages;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Hypertrophy
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new HomePage());
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
