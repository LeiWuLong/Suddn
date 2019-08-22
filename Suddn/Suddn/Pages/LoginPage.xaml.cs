using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Suddn.Pages
{
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        void OnButtonClick(object sender,EventArgs args)
        {
            btnLogin.Clicked += (_, e) => Navigation.PushAsync(new SuddnDashboard());
            
            //Navigation.PushAsync(new SuddnMap());
        }
    }
}
