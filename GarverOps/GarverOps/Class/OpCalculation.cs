using System;
using System.Collections.Generic;
using System.Text;
using org.mariuszgromada.math.mxparser;

namespace GarverOps.Class
{
    public class OpCalculation:INPCBase
    {



        public OpEquation Equation { get; set; }
        public decimal IsFavorite
        {
            get
            {
                if (Equation.Favorite) return 1; else return 0.2m;
            }
        }
        public bool InputVisible2 {
            get
            {
                if (Equation.InputName2 != "") return true; else return false;
            }
        }
        public bool InputVisible3
        {
            get
            {
                if (Equation.InputName3 != "") return true; else return false;
            }
        }

        public bool InputVisible4
        {
            get
            {
                if (Equation.InputName4 != "") return true; else return false;
            }
        }

        public bool InputVisible5
        {
            get
            {
                if (Equation.InputName5 != "") return true; else return false;
            }
        }

        private double resultvalue;
        public double ResultValue
        {
            get { return resultvalue; }
            set
            {
                resultvalue = value;
                OnPropertyChanged("ResultValue");
            }
        }
        public string ResultUnit { get; set; }


        private string resultstring;
        public string ResultString
        {
            get { return resultstring; }
            set
            {
                resultstring = value;
                OnPropertyChanged("ResultString");
            }
        }

        private double inputvalue1;
        public double InputValue1
        {
            get { return inputvalue1; }
            set
            {
                inputvalue1 = value;
                OnPropertyChanged("InputValue1");
                RunCalc();

            }
        }


        private double inputvalue2;
        public double InputValue2
        {
            get { return inputvalue2; }
            set
            {
                inputvalue2 = value;
                OnPropertyChanged("InputValue2");
                RunCalc();
            }
        }


        private double inputvalue3;
        public double InputValue3
        {
            get { return inputvalue3; }
            set
            {
                inputvalue3 = value;
                OnPropertyChanged("InputValue3");
                RunCalc();
            }
        }






        private double inputvalue4;
        public double InputValue4
        {
            get { return inputvalue4; }
            set
            {
                inputvalue4 = value;
                OnPropertyChanged("InputValue4");
                RunCalc();
            }
        }
        private double inputvalue5;
        public double InputValue5
        {
            get { return inputvalue5; }
            set
            {
                inputvalue5 = value;
                OnPropertyChanged("InputValue5");
                RunCalc();
            }
        }

        private void RunCalc()
        {
            Argument a = new Argument("a", 1);
            Argument b = new Argument("b", 1);
            Argument c = new Argument("c", 1);
            Argument d = new Argument("d", 1);
            Argument e = new Argument("e", 1);

            a.setArgumentValue(inputvalue1);
            b.setArgumentValue(inputvalue2);
            c.setArgumentValue(inputvalue3);
            d.setArgumentValue(inputvalue4);
            e.setArgumentValue(inputvalue5);

    


            
            if(InputVisible5)
            {
                Expression exp = new Expression(Equation.CalculationString, a, b,c,d,e);
                ResultValue = exp.calculate();
                ResultString = exp.getExpressionString() + "=" + ResultValue;
            }else

            if (InputVisible4)
            {
                Expression exp = new Expression(Equation.CalculationString, a, b, c, d);
                ResultValue = exp.calculate();
                ResultString = exp.getExpressionString() + "=" + ResultValue;
            }else

            if (InputVisible3)
            {
                Expression exp = new Expression(Equation.CalculationString, a, b, c);
                ResultValue = exp.calculate();
                ResultString = exp.getExpressionString() + "=" + ResultValue;
            }else
            if (InputVisible2)
            {
                Expression exp = new Expression(Equation.CalculationString, a, b);
                ResultValue = exp.calculate();
                ResultString = exp.getExpressionString() + "=" + ResultValue;
            }else
            {
                Expression exp = new Expression(Equation.CalculationString, a);
                ResultValue = exp.calculate();
                ResultString = exp.getExpressionString() + "=" + ResultValue;
            }



        }
    }
}
