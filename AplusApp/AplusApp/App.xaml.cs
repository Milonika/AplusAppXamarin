using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using AplusApp.TabPages;
namespace AplusApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new InformationProject();
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
