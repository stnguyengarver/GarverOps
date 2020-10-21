using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GarverOps
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            Device.SetFlags(new[] { "SwipeView_Experimental", "Expander_Experimental" });


            MainPage = new NavigationPage(new MainPage())
            {
                BarBackgroundColor = Color.FromRgb(120,47,64)
            };
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
