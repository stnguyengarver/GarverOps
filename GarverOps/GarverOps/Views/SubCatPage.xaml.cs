using GarverOps.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GarverOps.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SubCatPage : ContentPage
    {

        private SubCatVM subcatvm;
        public SubCatPage(string subcat)
        {
            subcatvm = new SubCatVM(subcat);
            this.BindingContext = subcatvm;
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