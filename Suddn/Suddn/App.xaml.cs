using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Suddn.Pages;
[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace Suddn
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new LoginPage());
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
