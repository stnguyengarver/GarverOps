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
    public class ProfilesVM : INPCBase
    {
        public ICommand ItemClicked
        {
            get
            {
                return new Command(p => ExecuteItemClicked(p));
            }

        }

        string _subcat;
        public ProfilesVM(string subcat)
        {
            _subcat = subcat;
            Title = subcat;
            Profiles = DataModel.GetSubcategories("Profiles");

        }

        private List<OpCalculation> profiles;
        public List<OpCalculation> Profiles
        {
            get { return profiles; }
            set
            {
                profiles = value;
                OnPropertyChanged("SubCats");
            }

        }


        public string Title { get; set; }


        public void ExecuteItemClicked(object obj)
        {
            int id = int.Parse(obj.ToString());

            DataModel.SetFavorite(id);
            Profiles = DataModel.GetSubcategories(_subcat);
        }
    }
}
