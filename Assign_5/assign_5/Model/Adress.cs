using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assign_5.model
{
    enum Country
    {
        USA,
        Sweden,
        Jamaica,
        Holland,
        Spain,
        Another
    }
    class Adress
    {
        private string street;
        private string zipC;
        private string city;


        public string Street
        {
            get { return street; }
            set { street = value; }
        }

        public string ZipC
        {
            get { return zipC; }
            set { zipC = value; }
        }

        public string City
        {
            get { return city; }
            set { city = value; }
        }

        public string getCountry(int num)
        {
            Country c;
            if (num == 0)
                c = Country.USA;
            else if (num == 1)
                c = Country.Sweden;
            else if (num == 2)
                c = Country.Jamaica;
            else if (num == 3)
                c = Country.Holland;
            else if (num == 4)
                c = Country.Spain;
            else
                c = Country.Another;

            return c.ToString();
        }
    }
}
