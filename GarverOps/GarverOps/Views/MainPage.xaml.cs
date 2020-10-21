using GarverOps.ViewModels;
using GarverOps.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace GarverOps
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        private MainPageVM mainPageVM;
        public MainPage()
        {
            InitializeComponent();
            mainPageVM = new MainPageVM();
            mainPageVM.Navigation = Navigation;
       
        
            this.BindingContext = mainPageVM;
        }

  

        private async void OpenAnimation()
        {
           // await swipeContent.ScaleYTo(0.6, 300, Easing.SinOut);
          //  pancake.CornerRadius = 40;
           // await swipeContent.RotateTo(-15, 300, Easing.SinOut);
        }

        private async void CloseAnimation()
        {
            //await swipeContent.RotateTo(0, 300, Easing.SinOut);
          //  pancake.CornerRadius = 0;
         //   await swipeContent.ScaleYTo(1, 300, Easing.SinOut);
        }

        private void OpenSwipe(object sender, EventArgs e)
        {
            MainSwipeView.Open(OpenSwipeItem.LeftItems);
          // OpenAnimation();
        }
 

        private void CloseSwipe(object sender, EventArgs e)
        {
            MainSwipeView.Close();
          //  CloseAnimation();
        }

        private void SwipeStarted(object sender, SwipeStartedEventArgs e)
        {
          //  OpenAnimation();
        }

        private void SwipeEnded(object sender, SwipeEndedEventArgs e)
        {
           // if (!e.IsOpen)
             //   CloseAnimation();
        }

  

        //private void CloseRequested(object sender, EventArgs e)
        //{
        //    CloseAnimation();
        //}
    }


}
