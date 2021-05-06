using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Controller
{
    class FuelController
    {
        fuelCalculator fc;

        String stringPrevOdo;
        String stringcurOdo;
        String stringcurAmount;
        String stringPrice;

        //Constructor to check Initial values
        public FuelController(String stringPrevOdo, String stringcurOdo, String stringcurAmount, String stringPrice)
        {
            this.stringPrevOdo = stringPrevOdo;
            this.stringcurOdo = stringcurOdo;
            this.stringcurAmount = stringcurAmount;
            this.stringPrice = stringPrice;
        }

        //Method to create a new object of FuelController after the values being checked
        public void createFuelController(int currentOdoReading, int PrevOdoReading, int currentAmountOfFuel, double price)
        {
            fc = new fuelCalculator(currentOdoReading, PrevOdoReading, currentAmountOfFuel, price);
        }


        //Check if strings are numeric
        public bool checkIfNumericFuel()
        {
            bool check = false ;
           
            if (stringcurOdo.All(char.IsDigit) || stringPrevOdo.All(char.IsDigit) || stringcurAmount.All(char.IsDigit) || stringPrice.All(char.IsDigit)) {
                check= true;
            }
            return check;
        }

        //check if strings are empty
        public bool checkIfEmptyFuel()
        {
            bool check = true;

            if ((string.IsNullOrEmpty(stringcurOdo)) || (string.IsNullOrEmpty(stringPrevOdo)) || (string.IsNullOrEmpty(stringcurAmount)) || (string.IsNullOrEmpty(stringPrice)))
            {
                check = false;
            }
            return check;
        }


   





        public double fuelCons_km_lit()
        {
            return fc.fuelCons_km_lit();
        }

        public double fuelCons_lit_km()
        {
            return fc.fuelCons_lit_km();
        }
        public double fuelCons_lit_metric()
        {
            return fc.fuelCons_lit_metric();
        }

        public double fuelCons_lit_swe()
        {
            return fc.fuelCons_lit_swe();
        }

        public double costPerKilometer()
        {
            return fc.costPerKilometer();
        }


    
}
}
