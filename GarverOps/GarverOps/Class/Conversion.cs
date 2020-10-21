using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace GarverOps.Class
{
    public class Conversion:INPCBase
    {
        public string Name { get; set; }
        public double Factor { get; set; }
        public string InputUnit { get; set; }
        public string OutputUnit { get; set; }

        private double answer;
        public double Answer
        {
            get { return answer; }
            set
            {
                    answer = value;
                    OnPropertyChanged("Answer");
            }
        }

        private double answer2;
        public double Answer2
        {
            get { return answer2; }
            set
            {
                answer2 = value;
                OnPropertyChanged("Answer2");
            }
        }

        private double inputvalue;
        public double InputValue
        {
            get { return inputvalue; }
            set
            {
                    inputvalue = value;
                    OnPropertyChanged("InputValue");
                    Answer = InputValue * Factor;
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
                Answer2 = InputValue2 / Factor;
            }

        }
    }
}
