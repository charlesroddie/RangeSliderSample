using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace RangeSliderTests
{
	public partial class App : Application
	{
		public App ()
		{
			InitializeComponent();
            var rs = new Xamarin.RangeSlider.Forms.RangeSlider
            {
                HorizontalOptions = LayoutOptions.FillAndExpand,
                MinimumValue = 0.0F,
                MaximumValue = 10.0F,
                LowerValue = 0.0F,
                MinThumbHidden = true
            };

            var bv = new BoxView
            {
                HeightRequest = 100.0
            };
          
            var sl = new StackLayout {
                Children =
                {
                    new BoxView
                    {
                        HeightRequest = 300.0,
                        WidthRequest = 100.0
                    },
                    rs,
                    new BoxView
                    {
                        HeightRequest = 300.0,
                        WidthRequest = 100.0
                    }
                }
            };

            var sv = new ScrollView
            {
                Content = sl
            };

            var p = new ContentPage
            {
                Content = sv
            };
            MainPage = p;
		}

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
