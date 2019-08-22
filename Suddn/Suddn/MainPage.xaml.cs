using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

using System.ComponentModel;
using System.Windows.Input;
//using LoginViewSample.Core.Services;

using Suddn.Pages;

namespace Suddn
{
    public partial class MainPage : ContentPage
    {
        public static readonly string apiKey = "AIzaSyC-vMol82Gj9OVkewE09ADdKMhduW77qgo";

        public MainPage()
        {
            InitializeComponent();



            Button button = new Button
            {
                Text = "Navigate!",
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center
            };

            button.Clicked += async (sender, args) =>
            {
                await Navigation.PushAsync(new LoginPage());
            };

            Content = button;
        }
    }
}