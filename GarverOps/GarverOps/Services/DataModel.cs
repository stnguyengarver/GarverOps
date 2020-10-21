using GarverOps.Class;
using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace GarverOps.Services
{
    public class DataModel
    {

        public static List<CalcMenu> GetFrontMenu()
        {
            return new List<CalcMenu>
            {


                new CalcMenu{
                    Name = "Wastewater Treatment",
                    Icon = "wastewater.png",
                    Code="None",
                    SubCat = new List<CalcMenu>
                    {
                       new CalcMenu{
                        Name="Flow Rate",
                        Icon="math.png",
                        Code="Flow Rate"},

                        new CalcMenu{
                        Name="Chlorination",
                        Icon="math.png",
                        Code="Chlorination"},


                        new CalcMenu{
                        Name="Loading/Pounds",
                        Icon="math.png",
                        Code="Loading/Pounds"},

                        new CalcMenu{
                        Name="Solids & Organic Loading",
                        Icon="math.png",
                        Code="Solids & Organic Loading"},

                        new CalcMenu{
                        Name="Trickling Filter",
                        Icon="math.png",
                        Code="Trickling Filter"},

                       new CalcMenu{
                        Name="Rotating Biological Contactor",
                        Icon="math.png",
                        Code="Rotating Biological Contactor"},


                        new CalcMenu{
                        Name="Sludge Digestion",
                        Icon="math.png",
                        Code="Sludge Digestion"},


                        new CalcMenu{
                        Name="Sludge Thickening",
                        Icon="math.png",
                        Code="Sludge Thickening"},

                        new CalcMenu{
                        Name="Stabilization Ponds",
                        Icon="math.png",
                        Code="Stabilization Ponds"},


                        new CalcMenu{
                        Name="Lab Work",
                        Icon="math.png",
                        Code="Lab Work"},





                        new CalcMenu{
                        Name="Grit Removal",
                        Icon="math.png",
                        Code="Grit Removal"},

                        new CalcMenu{
                        Name="Clarifiers",
                        Icon="math.png",
                        Code="Clarifiers"},

                        new CalcMenu{
                        Name="Activated Sludge",
                        Icon="math.png",
                        Code="Activated Sludge"},


                        new CalcMenu{
                        Name="Chemical Dosing",
                        Icon="math.png",
                        Code="Chemical Dosing"},


                    }
                },

                /*

                new CalcMenu{
                    Name = "Water Treatment",
                    Icon = "faucet.png",
                    Code="None",
                     SubCat = new List<CalcMenu>
                    {
                        new CalcMenu{
                        Name="To Be Implemented Soon",
                        Icon="math.png",
                        Code="To Be Implemented Soon"},

                    }
                },

                new CalcMenu{
                    Name = "Hydraulics and Pumping",
                    Icon = "pump.png",
                    Code="None",
                    SubCat = new List<CalcMenu>
                    {
                        new CalcMenu{
                        Name="Pumping",
                        Icon="math.png",
                        Code="Pumping"},

                        new CalcMenu{
                        Name="Hydraulics",
                        Icon="math.png",
                        Code="Hydraulics"}

                    }

                },



                */
                new CalcMenu{
                    Name = "Conversion & Math Formulas",
                    Icon = "math.png",
                    Code="None",
                    SubCat = new List<CalcMenu>
                    {
                        new CalcMenu{
                        Name="Conversions",
                        Icon="math.png",
                        Code="Conversions"},

                        new CalcMenu{
                        Name="Geometry",
                        Icon="math.png",
                        Code="Geometry"}


                    }
                },




                new CalcMenu{
                            Name = "References & Standards",
                            Icon = "standards.png",
                            Code="None",
                            SubCat= new List<CalcMenu>
                            {
                                new CalcMenu
                                {
                                    Name="EPA Water Standards Primary",
                                    Code="EPAPrimary"

                                },
                                /*

                                 new CalcMenu
                                {
                                    Name="EPA Water Standards Secondary",
                                    Code="EPASecondary"

                                }

                                 */
                            }




                },


                      new CalcMenu{
                          Name = "About Garver Water",
                          Icon = "g.png",
                          Code="Garver",
                         
                      }




            };
        }

        public static List<CalcMenu> GetLeftMenu()
        {
            return new List<CalcMenu>
            {
                new CalcMenu{ Name = "Home", Icon = "home.png",Code="Home"},

               // new CalcMenu{ Name = "Plant Profiles", Icon = "folder.png",Code="Profile"},
              //  new CalcMenu{ Name = "Messages", Icon = "envelope.png",Code="Messages"},
                new CalcMenu{ Name = "About Garver Water", Icon = "tasks.png",Code="Garver"},
            };
        }
        

        public static SQLiteData Data = new SQLiteData();

        public static int InsertData(OpEquation eq)
        {
            SQLiteConnection conn = Data.GetConnection();

          OpEquation foundeq =   conn.FindWithQuery<OpEquation>("select * from opequation where subcat=? and name=?",eq.SubCat,eq.Name);
           
            if (foundeq != null)
            {
                eq.Id = foundeq.Id;
                eq.Favorite = foundeq.Favorite;
                return conn.Update(eq);
               
            }else
            {
                return conn.Insert(eq);
            }
           

         

        }


        public static int DropEquation()
        {
            SQLiteConnection conn = Data.GetConnection();
           return  conn.DropTable<OpEquation>();
        }

        public static void CreateData()
        {
            SQLiteConnection conn = Data.GetConnection();


          
            InsertData(new OpEquation("Conversions", "Inches to Feet", "a*0.08333","Feet","Length", "Inch"));
            InsertData(new OpEquation("Conversions","Square Inches to Square Feet", "a*0.006944", "Sq Feet","Area","Square Inch"));
            InsertData(new OpEquation("Conversions","Feet to Miles", "a*0.0001893932", "Miles","Distance","Feet"));
            InsertData(new OpEquation("Conversions", "GPM to MGD", "a*0.00144", "MGD" ,"Flow","GPM"));
            InsertData(new OpEquation("Conversions","Liters to Gallons", "a*0.264172", "Gallons","Volume","Liters"));
            InsertData(new OpEquation("Conversions","kW to HP", "a*1.34102", "HP", "Power","kW"));
            InsertData(new OpEquation("Conversions", "lbs to kg", "a*.45359", "kg","Weight","lbs"));
            InsertData(new OpEquation("Conversions", "Water - lbs to gallon", "a*0.11983", "gal","Weight","lbs"));
            InsertData(new OpEquation("Conversions", "Water - lbs to cubic feet", "a*0.01602", "CF","Weight","lbs"));
            InsertData(new OpEquation("Conversions", "mg to grain", "a* 0.0154324", "grain","Weight","mg"));
            InsertData(new OpEquation("Conversions", "Water - psi to feet", "a*2.306726", "ft H20","Pressure","psi"));

            InsertData(new OpEquation("Geometry", "Volume of Box", "a*b*c", "cuft", "Length", "ft", "Width", "ft", "Height", "ft"));
            InsertData(new OpEquation("Geometry", "Perimeter of Rectangle", "2*(a+b)", "ft", "Length", "ft", "Width", "ft"));
            InsertData(new OpEquation("Geometry", "Area of Rectangle", "a*b", "sqft", "Length", "ft", "Width", "ft"));
            InsertData(new OpEquation("Geometry", "Volume of Cylinder", "b*pi*(a/2)^2", "cuft", "Diameter", "ft", "Height", "ft"));
            InsertData(new OpEquation("Geometry", "Circumference of Circle", "pi*a", "ft", "Diameter", "ft"));
            InsertData(new OpEquation("Geometry", "Area of Circle", "pi*(a/2)^2", "sqft", "Diameter", "ft"));

            //waste water
          //  InsertData(new OpEquation("Flow Rate", "Velocity", "a/b", "??", "??", "??", "??", "??"));
            InsertData(new OpEquation("Flow Rate", "Flow Rate - Velocity", "a/b*c", "CF/s", "Distance", "ft", "Time", "sec","Area","SF"));
            InsertData(new OpEquation("Flow Rate", "Flow Rate - Fill & Draw", "a/b", "CF/s", "Volume", "CF", "Time", "sec"));

            InsertData(new OpEquation("Chlorination", "Demand", "a-b", "mg/L", "Demand", "mg/L", "Residual", "mg/L"));
            InsertData(new OpEquation("Chlorination", "Dosage", "a*b/c*8.34", "mg/L", "Feed Rate", "lbs/day", "Chemical Purity", "%","Flow","CFS"));
            InsertData(new OpEquation("Chlorination", "Feed Rate", "a*b*8.34/c", "lbs/day", "Dosage", "mg/L", "Flow", "CFS","Chemical Purity","%"));
            InsertData(new OpEquation("Chlorination", "Detention Time", "a/b", "seconds", "Volume", "CF", "Flow", "CFS"));

            InsertData(new OpEquation("Loading/Pounds", "Loading", "a*b*8.34", "lb/day", "Concentration", "mg/L", "Flow", "gal/day"));
            InsertData(new OpEquation("Loading/Pounds", "Organic/Hydraulic", "a/b", "??", "Input1", "aaa", "Input2", "bbb"));
            InsertData(new OpEquation("Loading/Pounds", "Pounds", "a/b", "??", "Input1", "aaa", "Input2", "bbb"));

            InsertData(new OpEquation("Solids & Organic Loading", "Total Solids", "a/b", "%", "Input1", "aaa", "Input2", "bbb"));
            InsertData(new OpEquation("Solids & Organic Loading", "Total Suspended Soids", "a/b", "??", "Input1", "aaa", "Input2", "bbb"));
            InsertData(new OpEquation("Solids & Organic Loading", "Volatile Solids", "a/b", "??", "Input1", "aaa", "Input2", "bbb"));
            InsertData(new OpEquation("Solids & Organic Loading", "Volatile Suspended Solids", "a/b", "??", "Input1", "aaa", "Input2", "bbb"));
            InsertData(new OpEquation("Solids & Organic Loading", "Organic Nitrogen", "a/b", "??", "Input1", "aaa", "Input2", "bbb"));

            InsertData(new OpEquation("Grit Removal", "Velocity", "a/b", "ft/s", "Distance", "ft", "Time", "sec"));
            InsertData(new OpEquation("Grit Removal", "Grit Removed", "a/b", "CF/MG", "Volume of Grit", "CF/", "Volume of Flow", "MG"));


            InsertData(new OpEquation("Clarifiers", "Detention Time", "a/b/155557*24", "hrs", "Volume of Tank", "CF", "Flow", "MGD"));
            InsertData(new OpEquation("Clarifiers", "Surface Loading", "a/b*1000000", "GPD/SF", "Flow", "MGD", "Surface Area", "SF"));
            InsertData(new OpEquation("Clarifiers","Weir Overflow","a/b*1000000","GPD/ft","Flow","MGD","Length of Weir","ft"));
            InsertData(new OpEquation("Clarifiers","Solids Loading","8.345407*a*b/c","lbs/day/SF","Flow","MGD","Solids","mg/L","Surface Area","SF"));
            InsertData(new OpEquation("Clarifiers", "Percent Removal", "(a-b)/a*100", "%", "Influent", "mg/L", "Effluent", "mg/L"));
            InsertData(new OpEquation("Clarifiers", "BOD/Susp. Solids Removed", "a*b*8.34", "lbs/day", "BOD Removed", "mg/L", "Flow Rate", "MGD"));

            InsertData(new OpEquation("Trickling Filter", "Organic Loading Rate", "a/b", "??", "Input1", "aaa", "Input2", "bbb"));
            InsertData(new OpEquation("Trickling Filter", "Hydraulic Loading Rate", "a/b", "??", "Input1", "aaa", "Input2", "bbb"));
            InsertData(new OpEquation("Trickling Filter", "BOD/????", "a/b", "??", "Input1", "aaa", "Input2", "bbb"));

            InsertData(new OpEquation("Rotating Biological Contactor", "Organic??", "a/b", "??", "Input1", "aaa", "Input2", "bbb"));
            InsertData(new OpEquation("Rotating Biological Contactor", "Hydraulic??", "a/b", "??", "Input1", "aaa", "Input2", "bbb"));


            InsertData( new OpEquation("Activated Sludge", "Sludge Volume Index", "a*1000/b", "SVI", "Settleable Solids", "%(mL/L)", "MLSS", "mg/L"));
            InsertData( new OpEquation("Activated Sludge", "Aerator Solids", "a*b*8.3454", "lbs", "Tank Volume", "MG", "MLSS", "mg/L"));
            InsertData( new OpEquation("Activated Sludge", "Aerator Loading", "a*b*8.3454", "lbs/day", "Flow", "MGD", "Tank Influent BOD", "mg/L"));
            InsertData( new OpEquation("Activated Sludge", "Sludge Age", "a*b*c*d*8.3454", "days", "Tank Volume", "MG", "MLSS", "mg/L", "Flow", "MGD", "Tank Influent Suspended Solids", "mg/L"));
            InsertData(new OpEquation("Activated Sludge", "BOD/COD Organic Loading", "a/b", "??", "Input1", "aaa", "Input2", "bbb"));
            InsertData(new OpEquation("Activated Sludge", "MLSS", "a/b", "??", "Input1", "aaa", "Input2", "bbb"));
            InsertData(new OpEquation("Activated Sludge", "MLVSS", "a/b", "??", "Input1", "aaa", "Input2", "bbb"));
            InsertData(new OpEquation("Activated Sludge", "Food to Microorganism", "a/b", "??", "Input1", "aaa", "Input2", "bbb"));
            InsertData(new OpEquation("Activated Sludge", "MCRT or SRT", "a/b", "??", "Input1", "aaa", "Input2", "bbb"));
            InsertData(new OpEquation("Activated Sludge", "Desired MLVSS", "a/b", "??", "Input1", "aaa", "Input2", "bbb"));
            InsertData(new OpEquation("Activated Sludge", "Waste Sludge", "a/b", "??", "Input1", "aaa", "Input2", "bbb"));
            InsertData(new OpEquation("Activated Sludge", "Waste Sludge Pumping Rate", "a/b", "??", "Input1", "aaa", "Input2", "bbb"));
            InsertData(new OpEquation("Activated Sludge", "Return Activated Sludge", "a/b", "??", "Input1", "aaa", "Input2", "bbb"));

            InsertData(new OpEquation("Sludge Digestion", "Volatile Acid/Alky Ratio", "a/b", "??", "Input1", "aaa", "Input2", "bbb"));
            InsertData(new OpEquation("Sludge Digestion", "Total Solids Loading", "a/b", "??", "Input1", "aaa", "Input2", "bbb"));
            InsertData(new OpEquation("Sludge Digestion", "Volatile Solids Loading", "a/b", "??", "Input1", "aaa", "Input2", "bbb"));
            InsertData(new OpEquation("Sludge Digestion", "Digester Loading", "a/b", "??", "Input1", "aaa", "Input2", "bbb"));
            InsertData(new OpEquation("Sludge Digestion", "Volatile Solids Reduction %", "a/b", "??", "Input1", "aaa", "Input2", "bbb"));
            InsertData(new OpEquation("Sludge Digestion", "Volatile Solids Destroyed", "a/b", "??", "Input1", "aaa", "Input2", "bbb"));
            InsertData(new OpEquation("Sludge Digestion", "Gas Production", "a/b", "??", "Input1", "aaa", "Input2", "bbb"));
            InsertData(new OpEquation("Sludge Digestion", "Digestion Time", "a/b", "??", "Input1", "aaa", "Input2", "bbb"));

            InsertData(new OpEquation("Sludge Thickening", "Solids Concentration", "a/b", "??", "Input1", "aaa", "Input2", "bbb"));
            InsertData(new OpEquation("Sludge Thickening", "Sludge Production Rate", "a/b", "??", "Input1", "aaa", "Input2", "bbb"));
            InsertData(new OpEquation("Sludge Thickening", "Hydraulic Loading Rate", "a/b", "??", "Input1", "aaa", "Input2", "bbb"));
            InsertData(new OpEquation("Sludge Thickening", "Solids Loading Rate", "a/b", "??", "Input1", "aaa", "Input2", "bbb"));
            InsertData(new OpEquation("Sludge Thickening", "Sludge Detention Time", "a/b", "??", "Input1", "aaa", "Input2", "bbb"));

            InsertData(new OpEquation("Stabilization Ponds", "Organic Load Primary Cells", "a/b", "??", "Input1", "aaa", "Input2", "bbb"));
            InsertData(new OpEquation("Stabilization Ponds", "Storage Volume of Pond", "a/b", "??", "Input1", "aaa", "Input2", "bbb"));
            InsertData(new OpEquation("Stabilization Ponds", "Volume of Pond Discharged", "a/b", "??", "Input1", "aaa", "Input2", "bbb"));
            InsertData(new OpEquation("Stabilization Ponds", "Discharge Flow Rate", "a/b", "??", "Input1", "aaa", "Input2", "bbb"));
            InsertData(new OpEquation("Stabilization Ponds", "Detention Time", "a/b", "??", "Input1", "aaa", "Input2", "bbb"));


        

            InsertData( new OpEquation("Chemical Dosing", "Chemical Feeder Setting", "a*b*8.3454", "lbs/day", "Flow", "MGD", "Chemical Density", "mg/L"));
            InsertData( new OpEquation("Chemical Dosing", "Chlorine Demand", "a-b", "mg/L", "Chlorine Dose", "mg/L", "Chlorine Residual", "mg/L"));


            InsertData(new OpEquation("Lab Work", "Sludge Volume Index", "a/b", "??", "Input1", "aaa", "Input2", "bbb"));
            InsertData(new OpEquation("Lab Work", "Alkalinity", "a/b", "??", "Input1", "aaa", "Input2", "bbb"));
            InsertData(new OpEquation("Lab Work", "Hardness", "a/b", "??", "Input1", "aaa", "Input2", "bbb"));
            InsertData(new OpEquation("Lab Work", "BOD - Unseeded", "a/b", "??", "Input1", "aaa", "Input2", "bbb"));
            InsertData(new OpEquation("Lab Work", "Seed Correction Factor", "a/b", "??", "Input1", "aaa", "Input2", "bbb"));
            InsertData(new OpEquation("Lab Work", "BOD - Seeded", "a/b", "??", "Input1", "aaa", "Input2", "bbb"));
            InsertData(new OpEquation("Lab Work", "Total Suspened Solids", "a/b", "??", "Input1", "aaa", "Input2", "bbb"));
            InsertData(new OpEquation("Lab Work", "Volatile Suspended Solids", "a/b", "??", "Input1", "aaa", "Input2", "bbb"));
            InsertData(new OpEquation("Lab Work", "Volatile Suspended Solids %", "a/b", "??", "Input1", "aaa", "Input2", "bbb"));


            InsertData(new OpEquation("Profiles", "Northwest WWP", "a/b", "??", "Input1", "aaa", "Input2", "bbb"));
            InsertData(new OpEquation("Profiles", "Southwest WWP", "a/b", "??", "Input1", "aaa", "Input2", "bbb"));

        }


        public static List<OpCalculation> GetSubcategories(string subcat)
        {
            SQLiteConnection conn = Data.GetConnection();
            List<OpEquation> foundeq;

            if (subcat.ToUpper() == "FAVORITES")
            {
                foundeq = conn.Query<OpEquation>("select * from opequation where favorite = 1");
            }
            else
            {
                 foundeq = conn.Query<OpEquation>("select * from opequation where subcat=? ", subcat);
            }
           

            List<OpCalculation> rtnList = new List<OpCalculation>();
            OpEquation eq;

            if (foundeq != null)
            {
                foreach (var item in foundeq)
                {
                    OpCalculation neweq = new OpCalculation();
                    neweq.Equation = item;
                    rtnList.Add(neweq);

                }
             

            }

            return rtnList;
        }

        public static void SetFavorite(int id)
        {
            SQLiteConnection conn = Data.GetConnection();
            var command = conn.CreateCommand("Update opequation set favorite = not favorite where id=?",id);
            command.ExecuteNonQuery();
            conn.Commit();
        }
        public static List<OpCalculation> SearchCalcs(string searchtext)
        {
            SQLiteConnection conn = Data.GetConnection();
            List<OpEquation> foundeq;

            string query = "select * from opequation where name like '%" + searchtext.Trim() + "%' ";
            foundeq = conn.Query<OpEquation>(query);
          


            List<OpCalculation> rtnList = new List<OpCalculation>();
            OpEquation eq;

            if (foundeq != null)
            {
                foreach (var item in foundeq)
                {
                    OpCalculation neweq = new OpCalculation();
                    neweq.Equation = item;
                    rtnList.Add(neweq);

                }


            }

            return rtnList;
        }

    }
}
