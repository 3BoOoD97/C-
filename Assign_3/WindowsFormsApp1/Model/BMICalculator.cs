using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class BMICalculator
    {
        //declare the values
        private String name = "No name";
        private double hight = 0;
        private double wight = 0;
        private double result = 0;

        //Constructor to initialize the values
        public BMICalculator (String name , double hight , double wight)
        {
            this.name = name;
            this.hight = hight;
            this.wight = wight;
        }

        public String getname()
        {
            return name;
        }

        //mthod to calculate metric
        public double metric()
        {
            hight= hight / 100;
            hight= hight* hight;
            result = wight / hight;
            return result;
        }

        //mthod to calculate american
        public double american()
        {
            result = (wight * 703.0)/(hight*hight);
            return result;
        }

        //Method to give the weight range 
        public String nutritionalStatus()
        {
            if (result < 18.5)
            {
                return "Underweight";
            }
            else if (result > 18.5 && result < 24.9)
            {
                return "Normal weigh";
            }
            else if (result > 24.9 && result < 29.9)
            {
                return "Overweight ( Pre-obesity)";
            }
            else if (result > 29.9 && result < 34.9)
            {
                return "Obesity class I ";
            }
            else if (result > 34.9 && result < 39.9)
            {
                return "Obesity class II  "+result;
            }
            else 
                return "Obesity class III  ";
        }



    }

}
