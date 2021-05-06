using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class maintainWeightCalories
    {
        //declare the values
        double weight;
        double height;
        double BMR;

        //Constructor to initialize the values
        public maintainWeightCalories(double weight, double height,int age)
        {
            this.weight = weight;
            this.height = height;
            BMR = (10 * weight) + (6.25 * height) - (5 * age);

        }

        //calculation methods
        public double BMRFemale()
        {
            BMR= BMR - 161;
            return Math.Round(BMR);
        }

        public double BMRMale()
        {
            BMR= BMR + 5;
            return Math.Round(BMR);
        }

        public double sedentaryMaintainWeightCalories()
        {
            BMR= BMR * 1.2;
            return Math.Round(BMR) ;
        }

        public double lightlyActiveMaintainWeightCalories()
        {
            BMR = BMR * 1.375;
            return Math.Round(BMR) ;
        }

        public double moderatelyActiveMaintainWeightCalories()
        {
            BMR = BMR * 1.550;
            return Math.Round(BMR) ;
        }

   
        public double veryActiveMaintainWeightCalories()
        {
            BMR = BMR * 1.725;
            return Math.Round(BMR) ;
        }

        public double extraActiveMaintainWeightCalories()
        {
            BMR = BMR * 1.9;
            return Math.Round(BMR);
        }
        public double lose500gr()
        {
            return Math.Round(BMR -500);
        }

        public double lose1000gr()
        {
            return Math.Round(BMR - 1000);
        }

        public double add500gr()
        {
            return Math.Round(BMR +500);
        }

        public double add1000gr()
        {
            return Math.Round(BMR + 1000);
        }

        public string loseOrGain()
        {
            string str=""; 
            if (BMR - 1000 >100)
            {
                str = "Losing more than 1000 calories per day is to be avoided";
            }

            else if ((BMR - 500 > 100))
            {
                str = "Losing more than 500 calories per day is to be avoided";
            }
            return str;
        }

    }
}
