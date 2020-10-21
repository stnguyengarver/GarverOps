using GarverOps.Class;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace GarverOps.ViewModels
{
    public class EPAVM:INPCBase
    {

        private ObservableCollection<Standard> _standards;

       public  ObservableCollection<Standard> Standards
        {
            get { return _standards; }
            set
            {
                _standards = value;
                OnPropertyChanged("Standards");
            }
        }

        public string Title { get; set; }




        public EPAVM(string title)
        {

            Title = title;


            ObservableCollection<Standard> tabs_standards = new ObservableCollection<Standard>();
            List<GridRow> _rows;

            //Microorganisms
            Standard item = new Standard { Name = "Microorganisms" };
            _rows = new List<GridRow>();
            _rows.Add(new GridRow { Column1 = "Cryptosporidium", Column2 = "zero", Column3 = "TT3", Column4 = "Gastrointestinal illness (such as diarrhea, vomiting, and cramps)", Column5 = "Human and animal fecal waste" });
            _rows.Add(new GridRow { Column1 = "Giardia lamblia", Column2 = "zero", Column3 = "TT3", Column4 = "Gastrointestinal illness (such as diarrhea, vomiting, and cramps)", Column5 = "Human and animal fecal waste" });
            _rows.Add(new GridRow { Column1 = "Heterotrophic plate count(HPC)", Column2 = "n/a", Column3 = "TT3", Column4 = "HPC has no health effects; it is an analytic method used to measure the variety of bacteria that are common in water. The lower the concentration of bacteria in drinking water, the better maintained the water system is.", Column5 = "HPC measures a range of bacteria that are naturally present in the environment" });
            _rows.Add(new GridRow { Column1 = "Legionella", Column2 = "zero", Column3 = "TT3", Column4 = "Legionnaire's Disease, a type of pneumonia", Column5 = "Found naturally in water; multiplies in heating systems" });
            _rows.Add(new GridRow { Column1 = "Total Coliforms (including fecal coliform and E. Coli)", Column2 = "zero", Column3 = "5.0%", Column4 = "Not a health threat in itself; it is used to indicate whether other potentially harmful bacteria may be present", Column5 = "Coliforms are naturally present in the environment; as well as feces; fecal coliforms and E. coli only come from human and animal fecal waste." });
            _rows.Add(new GridRow { Column1 = "Turbidity", Column2 = "n/a", Column3 = "TT3", Column4 = "Turbidity is a measure of the cloudiness of water. It is used to indicate water quality and filtration effectiveness (such as whether disease-causing organisms are present). Higher turbidity levels are often associated with higher levels of disease-causing microorganisms such as viruses, parasites and some bacteria. These organisms can cause symptoms such as nausea, cramps, diarrhea, and associated headaches.", Column5 = "Soil runoff" });
            _rows.Add(new GridRow { Column1 = "Viruses (enteric)", Column2 = "zero", Column3 = "TT3", Column4 = "Gastrointestinal illness (such as diarrhea, vomiting, and cramps)", Column5 = "Human and animal fecal waste" });

            item.Rows = _rows;
            tabs_standards.Add(item);


            //DBP
            Standard item2 = new Standard { Name = "DBP" };
            _rows = new List<GridRow>();
            _rows.Add(new GridRow { 
                Column1 = "Bromate", 
                Column2 = "zero", 
                Column3 = "0.01", 
                Column4 = "Increased risk of cancer", 
                Column5 = "Byproduct of drinking water disinfection"
            });

            _rows.Add(new GridRow
            {
                Column1 = "Chlorite",
                Column2 = "0.8",
                Column3 = "1",
                Column4 = "Anemia; infants and young children: nervous system effects",
                Column5 = "Byproduct of drinking water disinfection"
            });

            _rows.Add(new GridRow
            {
                Column1 = "Haloacetic acids (HAA5)",
                Column2 = "n/a",
                Column3 = "0.06",
                Column4 = "Increased risk of cancer",
                Column5 = "Byproduct of drinking water disinfection"
            });

            _rows.Add(new GridRow
            {
                Column1 = "Total Trihalomethanes (TTHMs)",
                Column2 = "n/a",
                Column3 = "0.08",
                Column4 = "Liver, kidney or central nervous system problems; increased risk of cancer",
                Column5 = "Byproduct of drinking water disinfection"
            });


            item2.Rows = _rows;
            tabs_standards.Add(item2);



            //Disinfectants
            Standard item3 = new Standard { Name = "Disinfectants" };
            _rows = new List<GridRow>();
            _rows.Add(new GridRow
            {
                Column1 = "Chloramines (as Cl2)",
                Column2 = "MRDLG=41",
                Column3 = "MRDL=4.01",
                Column4 = "Eye/nose irritation; stomach discomfort, anemia",
                Column5 = "Water additive used to control microbes"
            });

            _rows.Add(new GridRow
            {
                Column1 = "Chlorine (as Cl2)",
                Column2 = "MRDLG=41",
                Column3 = "MRDL=4.01",
                Column4 = "Eye/nose irritation; stomach discomfort",
                Column5 = "Water additive used to control microbes"
            });
            _rows.Add(new GridRow
            {
                Column1 = "Chlorine dioxide (as ClO2)",
                Column2 = "MRDLG=41",
                Column3 = "MRDL=0.81",
                Column4 = "Anemia; infants and young children: nervous system effects",
                Column5 = "Water additive used to control microbes"
            });



            item3.Rows = _rows;
            tabs_standards.Add(item3);






            //"Inorganic Chemicals"
            Standard item4= new Standard { Name = "Inorganic Chemicals" };
            _rows = new List<GridRow>();



            _rows.Add(new GridRow
            {
                Column1 = "Antimony",
                Column2 = "0.006",
                Column3 = "0.006",
                Column4 = "Increase in blood cholesterol; decrease in blood sugar",
                Column5 = "Discharge from petroleum refineries; fire retardants; ceramics; electronics; solder"
            });
            _rows.Add(new GridRow
            {
                Column1 = "Arsenic",
                Column2 = "0",
                Column3 = "0.010",
                Column4 = "Skin damage or problems with circulatory systems, and may have increased risk of getting cancer",
                Column5 = "Erosion of natural deposits; runoff from orchards, runoff from glass and electronicsproduction wastes"
            });

            _rows.Add(new GridRow
            {
                Column1 = "Asbestos (fiber > 10 micrometers)",
                Column2 = "7 million fibers per liter (MFL)",
                Column3 = "7 MFL",
                Column4 = "Increased risk of developing benign intestinal polyps",
                Column5 = "Decay of asbestos cement in water mains; erosion of natural deposits"
            });
            _rows.Add(new GridRow
            {
                Column1 = "Barium",
                Column2 = "2",
                Column3 = "2",
                Column4 = "Increase in blood pressure",
                Column5 = "Discharge of drilling wastes; discharge from metal refineries; erosion of natural deposits"
            });

            _rows.Add(new GridRow
            {
                Column1 = "Beryllium",
                Column2 = "0.004",
                Column3 = "0.004",
                Column4 = "Intestinal lesions",
                Column5 = "Discharge from metal refineries and coal-burning factories; discharge from electrical, aerospace, and defense industries"
            });

            _rows.Add(new GridRow
            {
                Column1 = "Cadmium",
                Column2 = "0.005",
                Column3 = "0.005",
                Column4 = "Kidney damage",
                Column5 = "Corrosion of galvanized pipes; erosion of natural deposits; discharge from metal refineries; runoff from waste batteries and paints"
            });

            _rows.Add(new GridRow
            {
                Column1 = "Chromium (total)",
                Column2 = "0.1",
                Column3 = "0.1",
                Column4 = "Allergic dermatitis",
                Column5 = "Discharge from steel and pulp mills; erosion of natural deposits"
            });

            _rows.Add(new GridRow
            {
                Column1 = "Copper",
                Column2 = "1.3",
                Column3 = "TT7; Action Level=1.3",
                Column4 = "Short term exposure: Gastrointestinal distress",
                Column5 = "Corrosion of household plumbing systems; erosion of natural deposits"
            });
            _rows.Add(new GridRow
            {
                Column1 = "Cyanide (as free cyanide)",
                Column2 = "0.2",
                Column3 = "0.2",
                Column4 = "Nerve damage or thyroid problems",
                Column5 = "Discharge from steel/metal factories; discharge from plastic and fertilizer factories"
            });

            _rows.Add(new GridRow
            {
                Column1 = "Fluoride",
                Column2 = "4",
                Column3 = "4",
                Column4 = "Bone disease (pain and tenderness of the bones); Children may get mottled teeth",
                Column5 = "Water additive which promotes strong teeth; erosion of natural deposits; discharge from fertilizer and aluminum factories"
            });

            _rows.Add(new GridRow
            {
                Column1 = "Lead",
                Column2 = "zero",
                Column3 = "TT7; Action Level=0.015",
                Column4 = "Infants and children: Delays in physical or mental development; children could show slight deficits in attention span and learning abilities. Adults: Kidney problems; high blood pressure",
                Column5 = "Corrosion of household plumbing systems; erosion of natural deposits"
            });

            _rows.Add(new GridRow
            {
                Column1 = "Mercury (inorganic)",
                Column2 = "0.002",
                Column3 = "0.002",
                Column4 = "Kidney damage",
                Column5 = "Erosion of natural deposits; discharge from refineries and factories; runoff from landfills and croplands"
            });

            _rows.Add(new GridRow
            {
                Column1 = "Nitrate (measured as Nitrogen)",
                Column2 = "10",
                Column3 = "10",
                Column4 = "Infants below the age of six months who drink water containing nitrate in excess of the MCL could become seriously ill and, if untreated, may die. Symptoms include shortness of breath and blue-baby syndrome.",
                Column5 = "Runoff from fertilizer use; leaking from septic tanks, sewage; erosion of natural deposits"
            });


            _rows.Add(new GridRow
            {
                Column1 = "Nitrite (measured as Nitrogen)",
                Column2 = "1",
                Column3 = "1",
                Column4 = "Infants below the age of six months who drink water containing nitrite in excess of the MCL could become seriously ill and, if untreated, may die. Symptoms include shortness of breath and blue-baby syndrome.",
                Column5 = "Runoff from fertilizer use; leaking from septic tanks, sewage; erosion of natural deposits"
            });

            _rows.Add(new GridRow
            {
                Column1 = "Selenium",
                Column2 = "0.05",
                Column3 = "0.05",
                Column4 = "Hair or fingernail loss; numbness in fingers or toes; circulatory problems",
                Column5 = "Discharge from petroleum refineries; erosion of natural deposits; discharge from mines"
            });

            _rows.Add(new GridRow
            {
                Column1 = "Thallium",
                Column2 = "0.0005",
                Column3 = "0.002",
                Column4 = "Hair loss; changes in blood; kidney, intestine, or liver problems",
                Column5 = "Leaching from ore-processing sites; discharge from electronics, glass, and drug factories"
            });


            item4.Rows = _rows;
            tabs_standards.Add(item4);




            //"Organic Chemicals"
            Standard item5 = new Standard { Name = "Organic Chemicals" };
            _rows = new List<GridRow>();
            _rows.Add(new GridRow
            {
                Column1 = "Acrylamide",
                Column2 = "zero",
                Column3 = "TT8",
                Column4 = "Nervous system or blood problems; increased risk of cancer",
                Column5 = "Added to water during sewage/wastewater treatment"
            });

            _rows.Add(new GridRow
            {
                Column1 = "Alachlor",
                Column2 = "zero",
                Column3 = "0.002",
                Column4 = "Eye, liver, kidney or spleen problems; anemia; increased risk of cancer",
                Column5 = "Runoff from herbicide used on row crops"
            });


            _rows.Add(new GridRow
            {
                Column1 = "Atrazine",
                Column2 = "0.003",
                Column3 = "0.003",
                Column4 = "Cardiovascular system or reproductive problems",
                Column5 = "Runoff from herbicide used on row crops"
            });

            _rows.Add(new GridRow
            {
                Column1 = "Benzene",
                Column2 = "zero",
                Column3 = "0.005",
                Column4 = "Anemia; decrease in blood platelets; increased risk of cancer",
                Column5 = "Discharge from factories; leaching from gas storage tanks and landfills"
            });

            _rows.Add(new GridRow
            {
                Column1 = "Benzo(a)pyrene (PAHs)",
                Column2 = "zero",
                Column3 = "0.0002",
                Column4 = "Reproductive difficulties; increased risk of cancer",
                Column5 = "Leaching from linings of water storage tanks and distribution lines"
            });
            _rows.Add(new GridRow
            {
                Column1 = "Carbofuran",
                Column2 = "0.04",
                Column3 = "0.04",
                Column4 = "Problems with blood, nervous system, or reproductive system",
                Column5 = "Leaching of soil fumigant used on rice and alfalfa"
            });
            _rows.Add(new GridRow
            {
                Column1 = "Carbon tetrachloride",
                Column2 = "zero",
                Column3 = "0.005",
                Column4 = "Liver problems; increased risk of cancer",
                Column5 = "Discharge from chemical plants and other industrial activities"
            });

            _rows.Add(new GridRow
            {
                Column1 = "Chlordane",
                Column2 = "zero",
                Column3 = "0.002",
                Column4 = "Liver or nervous system problems; increased risk of cancer",
                Column5 = "Residue of banned termiticide"
            });

            _rows.Add(new GridRow
            {
                Column1 = "Chlorobenzene",
                Column2 = "0.1",
                Column3 = "0.1",
                Column4 = "Liver or kidney problems",
                Column5 = "Discharge from chemical and agricultural chemical factories"
            });








            item5.Rows = _rows;
            tabs_standards.Add(item5);
























            //"Radionuclides"
            Standard item6 = new Standard { Name = "Radionuclides" };
            _rows = new List<GridRow>();
            _rows.Add(new GridRow
            {
                Column1 = "Alpha particles",
                Column2 = "none ---------- zero",
                Column3 = "15 picocuries per Liter (pCi/L)",
                Column4 = "Increased risk of cancer",
                Column5 = "Erosion of natural deposits of certain minerals that are radioactive and may emit a form of radiation known as alpha radiation"
            });

            _rows.Add(new GridRow
            {
                Column1 = "Beta particles and photon emitters",
                Column2 = "none ---------- zero",
                Column3 = "4 millirems per year",
                Column4 = "Increased risk of cancer",
                Column5 = "Decay of natural and man-made deposits of"
            });

            _rows.Add(new GridRow
            {
                Column1 = "Radium 226 and Radium 228 (combined)",
                Column2 = "none ---------- zero",
                Column3 = "5 pCi/L",
                Column4 = "Increased risk of cancer",
                Column5 = "Erosion of natural deposits"
            });

            _rows.Add(new GridRow
            {
                Column1 = "Uranium",
                Column2 = "zero",
                Column3 = "5 pCi/L",
                Column4 = "30 ug/L as of 12/08/03",
                Column5 = "Erosion of natural deposits"
            });




            item6.Rows = _rows;
            tabs_standards.Add(item6);
       


            Standards = tabs_standards;


      
        }
    }
}
