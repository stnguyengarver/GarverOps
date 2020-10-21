using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace GarverOps
{
    public class INPCBase : INotifyPropertyChanged
    {
        #region INPC

        public event PropertyChangedEventHandler PropertyChanged;


        public void OnPropertyChanged(String info)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(info));
            }
        }



        #endregion

    }
}
