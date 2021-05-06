using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class fuelCalculator
    {
        //declare the values

        private int currentOdoReading;
        private int PrevOdoReading;
        private int currentAmountOfFuel;
        private double price;
        private double km;

        //Constructor to initialize the values
        public fuelCalculator(int currentOdoReading, int PrevOdoReading, int currentAmountOfFuel, double price)
        {
            this.currentOdoReading = currentOdoReading;
            this.PrevOdoReading = PrevOdoReading;
            this.currentAmountOfFuel = currentAmountOfFuel;
            this.price =price;

            //calculate km 
            km = currentOdoReading - PrevOdoReading;
        }

        //calculation methods
        public double fuelCons_km_lit()
        {
            return km / currentAmountOfFuel;
        }

        public double fuelCons_lit_km()
        {
            return currentAmountOfFuel / km;
        }
        public double fuelCons_lit_metric()
        {
            return fuelCons_lit_km() / 0.621371192;
        }

        public double fuelCons_lit_swe()
        {
            return fuelCons_lit_km() * 10;
        }

        public double costPerKilometer()
        {
            return fuelCons_lit_km() * price;
        }

       
    }
}
