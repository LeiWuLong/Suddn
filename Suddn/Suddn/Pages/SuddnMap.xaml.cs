using System;
using System.Collections.Generic;

using Xamarin.Forms;
//using Xamarin.Forms.GoogleMaps;
using Xamarin.Forms.GoogleMaps;



namespace Suddn.Pages
{
    public partial class SuddnMap : ContentPage
    {
        public SuddnMap()
        {//tae
            InitializeComponent ();
           // Xamarin.FormsGoogleMaps.Init("AIzaSyC-vMol82Gj9OVkewE09ADdKMhduW77qgo"); //initialize the map -ios.


            //var map = new Map(
            //MapSpan.FromCenterAndRadius(
            ////new Position(14.55, 121.0244), Distance.FromMiles(0.3)))
            var position = new Xamarin.Forms.GoogleMaps.Position(14.5599303, 121.0135896);

            ////var map = new Map()
            //{
            //  //  IsShowingUser = true,
            //    HeightRequest = 100,
            //    WidthRequest = 960,
            //    VerticalOptions = LayoutOptions.FillAndExpand
            //};

            var pin = new Xamarin.Forms.GoogleMaps.Pin
            {   Type = Xamarin.Forms.GoogleMaps.PinType.Place,
                
                Position = position,
                Label = "my position"
            };
            //gMap.MapType = Xamarin.Forms.GoogleMaps.MapType.Street;
            //gMap.Pins.Add(pin);
            //gMap.MoveToRegion(Xamarin.Forms.GoogleMaps.MapSpan.FromCenterAndRadius(position, Xamarin.Forms.GoogleMaps.Distance.FromMiles(1)));


            //var stack = new StackLayout { Spacing = 0 };
            //stack.Children.Add(gMap);
            //Content = stack;


            //map.MapType == MapType.Street;
        }

        
    }
}
