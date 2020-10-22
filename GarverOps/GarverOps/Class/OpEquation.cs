

using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace GarverOps.Class
{
    public class OpEquation
    {
        public OpEquation()
        {

        }
        public OpEquation(string subcat,string name,string calcstring,string result, string input1, string unit1, string input2="",  string unit2="", string input3="",string unit3="", string input4 = "", string unit4 = "", string input5 = "", string unit5 = "")
        {
            SubCat = subcat;
            Name = name;
            ResultUnit = result;
            CalculationString = calcstring;
            InputName1 = input1;
            InputName2 = input2;
            InputName3 = input3;
            InputName4 = input4;
            InputName5 = input5;



            InputUnit1 = unit1;
            InputUnit2 = unit2;
            InputUnit3 = unit3;
            InputUnit4 = unit4;
            InputUnit5 = unit5;

        }

        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        public bool Favorite { get; set; }
        public string SubCat { get; set; }
        public string Name { get; set; }
        public string Icon { get; set; }

        public string CalculationString { get; set; }
        public string InputUnit1 { get; set; }
        public string InputUnit2 { get; set; }
        public string InputUnit3 { get; set; }
        public string InputUnit4 { get; set; }
        public string InputUnit5 { get; set; }

        public string InputName1 { get; set; }
        public string InputName2 { get; set; }
        public string InputName3 { get; set; }
        public string InputName4 { get; set; }
        public string InputName5 { get; set; }

   
        public string ResultUnit { get; set; }


    }
}
