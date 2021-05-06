using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Controller
{
    class BmiController
    {
        BMICalculator BMI;
        String strhigh;
        String strweight;
        bool bol = true;

        //Constructor to initialize the values after being checked
        public BmiController(String name, double hight, double wight)
        {
            BMI = new BMICalculator(name, hight, wight);
        }

        //Constructor to check Initial values
        public BmiController(String strhigh, String strweight)
        {
            this.strhigh = strhigh;
            this.strweight = strweight;
        }

        //Get methods from BMICalculator 
        public String getname()
        {
            return BMI.getname();
        }

        public double metric()
        {
            return BMI.metric();
        }

        public double american()
        {
            return BMI.american();
        }

        public String nutritionalStatus()
        {
            return BMI.nutritionalStatus();
        }

        //Check if strings are numeric
        public void checkIfNumericIbm()
        {
            if (double.TryParse(strhigh, out _) && (double.TryParse(strweight, out _)))
            {
                bol = true;
            }
            else
                bol = false;
        }

        //check if strings are empty
        public void checkIfEmptyIbm()
        {
            if ((string.IsNullOrEmpty(strhigh)) || (string.IsNullOrEmpty(strweight)))
            {
                bol = false;
            }
        }

        //Check if checkIfNumericIbm and checkIfEmptyIbm are true or false
        public Boolean checkIbm()
        {
            checkIfNumericIbm();
            checkIfEmptyIbm();
            return bol;
        }
    }
}
