using GarverOps.Class;
using GarverOps.Services;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace GarverOps.ViewModels
{
    public class SearchVM : INPCBase
    {
        public SQLiteData Data = DataModel.Data;

        public INavigation Navigation { get; set; }
        private string searchtext="";
        private string searchmessage;

        public SearchVM(List<OpCalculation> subcats, string searchstring)
        {
            if(subcats != null)
            {
                SubCats = subcats;
                SearchText = searchstring;
                if (SubCats.Count > 0) SearchMessage = "Results Found for :" + SearchText;
                else SearchMessage = "Results Not Found for .." + SearchText;
            }

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
        public string SearchText
        {
            get { return searchtext; }
            set
            {
                searchtext = value;
                OnPropertyChanged("SearchText");
            }
        }


        public string SearchMessage
        {
            get { return searchmessage; }
            set
            {
                searchmessage = value;
                OnPropertyChanged("SearchMessage");
            }
        }

        public ICommand SearchClicked
        {
            get
            {
                return new Command( p => ExecuteSearchClicked(p));
            }

        }

        public void ExecuteSearchClicked(object obj)
        {

           SubCats =  DataModel.SearchCalcs(searchtext);

            if (SubCats.Count > 0) SearchMessage = "Results Found for :" + SearchText;
            else SearchMessage = "Results Not Found for .." + SearchText;

        }
    }
}
