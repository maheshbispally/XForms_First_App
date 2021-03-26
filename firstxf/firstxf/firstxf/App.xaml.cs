using firstxf.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace firstxf
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

             //MainPage = new basic_login_view();
            ///MainPage = new registration();
            MainPage = new NavigationPage(new LoginView());


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
