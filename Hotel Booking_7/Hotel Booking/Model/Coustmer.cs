using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Booking.Model
{
    class Coustmer
    {
        //Declare values
        private string coustmerName;
        private int coustmerAge;
        private int coustmerPersonalNumber;
        private int coustmerPhoneNumber;
        private string coustmerAdress;

        //Set and get properties of the declared values
        public string CoustmerName
        {
            get { return coustmerName; }
            set { coustmerName = value; }
        }

        public int CoustmerAge
        {
            get { return coustmerAge; }
            set { coustmerAge = value; }
        }


        public int CoustmerPersonalNumber
        {
            get { return coustmerPersonalNumber; }
            set { coustmerPersonalNumber = value; }
        }

        public int CoustmerPhoneNumber
        {
            get { return coustmerPhoneNumber; }
            set { coustmerPhoneNumber = value; }
        }


        public string CoustmerAdress
        {
            get { return coustmerAdress; }
            set { coustmerAdress = value; }
        }


    }
}
