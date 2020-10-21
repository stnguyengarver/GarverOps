using GarverOps.Class;
using GarverOps.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace GarverOps.ViewModels
{
    public class SubCatVM:INPCBase
    {
        public ICommand ItemClicked
        {
            get
            {
                return new Command(p => ExecuteItemClicked(p));
            }

        }

        string _subcat;
        public SubCatVM(string subcat)
        {
            _subcat = subcat;
            Title = subcat;
            SubCats = DataModel.GetSubcategories(subcat);
          
        }

        private List<OpCalculation> subcats;
        public List<OpCalculation> SubCats
        {
            get { return subcats; }
            set
            {
                subcats = value;
                OnPropertyChanged("SubCats");
            }

        }


        public string Title { get; set; }


        public void ExecuteItemClicked(object obj)
        {
            int id = int.Parse(obj.ToString());

            DataModel.SetFavorite(id);
            SubCats = DataModel.GetSubcategories(_subcat);
        }
    }
}
