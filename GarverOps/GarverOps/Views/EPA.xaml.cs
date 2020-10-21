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
    public partial class EPA : TabbedPage
    {
        private EPAVM epa;
        public EPA(string title)
        {
            epa = new EPAVM(title);
            this.BindingContext = epa;
            this.ItemsSource = epa.Standards;

            InitializeComponent();
        }
    }
}