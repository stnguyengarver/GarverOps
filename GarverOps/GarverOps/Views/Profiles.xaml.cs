using GarverOps.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GarverOps.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Profiles : ContentPage
    {
        private ProfilesVM profilesvm;
        public Profiles()
        {
            profilesvm = new ProfilesVM("profiles");
            this.BindingContext = profilesvm;
            InitializeComponent();
        }

        protected void Txt_Focussed(object sender, FocusEventArgs e)
        {

            Dispatcher.BeginInvokeOnMainThread(() =>
            {
                Entry txt = (Entry)sender;
                txt.CursorPosition = 0;
                txt.SelectionLength = txt.Text.Length;
                txt.Focus();
            });

        }
    }
}