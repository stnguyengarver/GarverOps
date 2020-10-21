using Android.Hardware.Camera2;
using GarverOps.Class;
using GarverOps.Services;
using GarverOps.Views;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace GarverOps.ViewModels
{
    class MainPageVM:INPCBase
    {
        public SQLiteData Data = DataModel.Data;

        public INavigation Navigation { get; set; }
        public List<CalcMenu> MyCalcMenu { get; set; }

        public List<CalcMenu> CalcMenuFront { get; set; }

        public ICommand ItemClicked
        {
            get
            {
               return new Command(async p => await ExecuteItemClicked(p));
            }

        }

        public async Task ExecuteItemClicked(object obj)
        {
            string subcat = obj.ToString();

          

            switch(subcat)
            {

                case "Home":
                        await Navigation.PopToRootAsync();
                    break;
                case "Garver":
                case "About Garver Water":
                  
                        await Browser.OpenAsync("http://garverusa.com/services/water", BrowserLaunchMode.SystemPreferred);

                    break;


                case "Plant Profiles":
                    await Navigation.PushAsync(new Profiles());
                    break;


                // case "Conversions":
                // await Navigation.PushAsync(new Conversions());
                // break;

                case "Pumping":
                case "Hydraulics":
                case "To Be Implemented Soon":
                    await Navigation.PushAsync(new Page1());
                    break;

                case "None":
                    break;

                case "EPAPrimary":
                   await Navigation.PushAsync(new EPA("EPA Primary DW Standards"));
       
                    break;

                case "EPApdf":
              
                    await Browser.OpenAsync("https://www.epa.gov/sites/production/files/2016-06/documents/npwdr_complete_table.pdf", BrowserLaunchMode.SystemPreferred);
                    break;

                default:
                        await Navigation.PushAsync(new SubCatPage(subcat));
                    break;
            }
        
           foreach(var item in CalcMenuFront)
            {
                item.IsExpanded = false;
            }
        }

        public MainPageVM()
        {
          // DataModel.DropEquation();
            MyCalcMenu = DataModel.GetLeftMenu();
            CalcMenuFront = DataModel.GetFrontMenu();
            DataModel.CreateData();
          
      
        }


        /// <summary>
        /// ///////////////////////////////////////////////////   search
        /// </summary>

        private string searchtext="";
        private string searchmessage;

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
                return new Command(p => ExecuteSearchClicked(p));
            }

        }

        public void ExecuteSearchClicked(object obj)
        {

            SubCats = DataModel.SearchCalcs(searchtext);

            if (SubCats.Count > 0)
            {
               
                Navigation.PushAsync(new Search(SubCats,SearchText));
            }
            else
            {
                SearchMessage = "Results Not Found for .." + SearchText;


                Application.Current.MainPage.DisplayAlert("alert", SearchMessage, "ok");
            }
        }

 

    }
}
