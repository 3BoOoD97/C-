using Hotel_Booking.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Booking.Controller
{
    public class CoustmerController
    {
        private Coustmer coustmer = new Coustmer();

        private int selectedIndex;
        public int SelectedIndex
        {
            get { return selectedIndex; }
            set { selectedIndex = value; }
        }

        int coustmerID;
        public int CoustmerID
        {
            get { return coustmerID; }
            set { coustmerID = value; }
        }

        


        public void setCoustmerName(string name)
        {
            coustmer.CoustmerName = name;
        }

        public string getCoustmerName()
        {
            return coustmer.CoustmerName;
        }

        public void setCoustmerAge(int age)
        {
            coustmer.CoustmerAge = age;
        }

        public int getCoustmerAge()
        {
            return coustmer.CoustmerAge;
        }

        public void setCoustmerPersonalNumber(int personalNum)
        {
            coustmer.CoustmerPersonalNumber = personalNum;
        }

        public int getCoustmerPersonalNumber()
        {
            return coustmer.CoustmerPersonalNumber;
        }

        public void setCoustmerPhoneNumber(int phoneNum) 
        {
            coustmer.CoustmerPhoneNumber = phoneNum;
        }

        public int getCoustmerPhoneNumber()
        {
            return coustmer.CoustmerPhoneNumber;
        }

        public void setCoustmerAdress(string adress)
        {
            coustmer.CoustmerAdress = adress;
        }

        public string getCoustmerAdress()
        {
            return coustmer.CoustmerAdress;
        }





    }
}
