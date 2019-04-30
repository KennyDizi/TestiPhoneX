using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using connect.me.mobile.Views;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace connect.me.mobile
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            //this.MainPage = new NavigationPage(new Page1());
            MainPage = new MainPage();
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
