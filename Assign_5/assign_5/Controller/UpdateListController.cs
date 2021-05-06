using assign_5.model;
using assign_5.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assign_5.Controller
{
   public class UpdateListController
    {
        ContactList cList = new ContactList();


        public ArrayList updateList(NameController nc, AdressController ac, int countryIndex) // this method calling model to add a contact and refreh the list
        {
            string memberInfo = nc.getFirstName()+","+nc.getLaststName()+ "-" + ac.getStreet() + "-" + ac.getCity()+ "-" + ac.getZip()+ "-" + ac.getCountry(countryIndex);
            cList.addMember(memberInfo);
           return cList.getArray();
        }

       public void Remove(int index)
        {
            cList.removeMember(index);
        }

        public void changeInfo(int index, string str) //This method calling model to change a specific contact info
        {
            cList.changeMember(index, str);
        }


        //the methods below divied an elment of a given position in the arraylist into Strings to print it in the view once the user want to change a member info

        public string getFirstNameFromList (int index)
        {
          string first=  cList.getFirstNameFromList(index);
            return first;
        }

        public string getLastNameFromList()
        {
            string last = cList.getLastNameFromList();
            return last;
        }
         public string getStreetFromList()
        {
            string street = cList.getStreetFromList();
            return street;
        }
        public string getCityFromList() {
            string city = cList.getCityFromList();
            return city;
        }
        public string getZipFromList()
        {
            string zip = cList.getZipFromList();
            return zip;
        }

        public int getCountryFromList()
        {
            return cList.getCountryFromList();
        }
    }
}
