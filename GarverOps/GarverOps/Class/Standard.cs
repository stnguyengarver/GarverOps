using System;
using System.Collections.Generic;
using System.Text;

namespace GarverOps.Class
{
    public class Standard:INPCBase
    {

        public string Name { get; set; }

        private List<GridRow> rows;
        public List<GridRow> Rows
        {
            get { return rows; }
            set
            {
                rows = value;
                OnPropertyChanged("Rows");
            }
        }
    }
}
