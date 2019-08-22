using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Suddn.Pages
{
    public partial class SuddnDashboard : ContentPage
    {
        public SuddnDashboard()
        {
            InitializeComponent();
        }

        void DineClicked(object sender, EventArgs args)
        {
            //btnDine.Clicked += (_, e) => Navigation.PushAsync(new SuddnMap());
           
        }

        void DrinksClicked(object sender, EventArgs args)
        {
            //btnDrinks.Clicked += (_, e) => Navigation.PushAsync(new SuddnMap());
           
        }
    }
}
