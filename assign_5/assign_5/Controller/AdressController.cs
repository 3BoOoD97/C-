using assign_5.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assign_5.Controller
{
   public class AdressController
    {
        Adress ad = new Adress(); 


        public void setStreet(string street)
        {
            ad.Street = street;
        }

        public string getStreet()
        {
            return ad.Street;
        }

        public void setZip(string Zip)
        {
            ad.ZipC = Zip;
        }

        public string getZip()
        {
            return ad.ZipC;
        }
         public void setCity(string city)
        {
            ad.City = city;
        }

        public string getCity()
        {
            return ad.City;
        }

     public string getCountry(int index)
        {
            return ad.getCountry(index);
        }

    }
}
