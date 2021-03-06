﻿using Vistoria.Apresentacao;
using Xamarin.Forms;

namespace Vistoria
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            //MainPage = new Vistoria.MainPage();
            MainPage = new NavigationPage(new Vistoria.Apresentacao.MenuPage());
            //MainPage = new HomeTabbedPage(new MenuPage());
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
