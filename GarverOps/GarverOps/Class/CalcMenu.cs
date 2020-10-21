using System;
using System.Collections.Generic;
using System.Text;

namespace GarverOps.Class
{
    public class CalcMenu:INPCBase
    {
        public string Name { get; set; }
        public string Icon { get; set; }

        public string Code { get; set; }

        private bool isexpanded;
        public bool IsExpanded
        {
            get { return isexpanded; }
            set
            {
                isexpanded = value;
                OnPropertyChanged("IsExpanded");
                if (isexpanded)
                {
                    ExpandIcon = "uparrow.png";
                }
                else ExpandIcon = "arrowdown.png";

            }

        }


        private string expandicon = "arrowdown.png";
        public string ExpandIcon
        {
            get { return expandicon; }
            set
            {
                expandicon = value;
                OnPropertyChanged("ExpandIcon");
            }
        }

        public List<CalcMenu> SubCat { get; set; }
    }
}
