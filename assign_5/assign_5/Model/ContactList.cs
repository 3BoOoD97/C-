using assign_5.model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assign_5.Model
{
     class ContactList
    {
        private string currentMember;
        int firstnameIndex = 0;
        int lastNameIndex = 0;
        int streetIndex = 0;
        string firstName;

        private ArrayList membersList= new ArrayList();

        public void addMember(string newMember)
        {
            membersList.Add(newMember);
        }


        public ArrayList getArray()
        {
            return membersList;
        }


        public void removeMember(int index)
        {
            membersList.RemoveAt(index);
        }


        public void changeMember(int index, string memberAfterChange)
        {
            membersList[index] = memberAfterChange;
        }



        public string getFirstNameFromList(int index) // This method to get the first name from a given index
        {
            currentMember = membersList[index].ToString();
            string separator = ",";
             firstnameIndex = currentMember.IndexOf(separator);
            firstName = currentMember.Substring(0, firstnameIndex);
            currentMember = currentMember.Substring(firstnameIndex + separator.Length);
            return firstName;
        }

        public string getLastNameFromList()
        {
            string separator = "-";
            lastNameIndex = currentMember.IndexOf(separator);
            string Last = currentMember.Substring(0, lastNameIndex);
            currentMember = currentMember.Substring(lastNameIndex + separator.Length);

            return Last;
        }

        public string getStreetFromList()
        {
          string separator = "-";
            streetIndex = currentMember.IndexOf(separator);
            string street = currentMember.Substring(0, streetIndex);
            currentMember = currentMember.Substring(streetIndex + separator.Length);
            return street;
        }

        public string getCityFromList()
        {
            string separator = "-";
            int cityIndex = currentMember.IndexOf(separator);
            string city = currentMember.Substring(0, cityIndex);
            currentMember = currentMember.Substring(cityIndex + separator.Length);
            return city;
        }

        public string getZipFromList()
        {
            string separator = "-";
            int zipIndex = currentMember.IndexOf(separator);
            string zip = currentMember.Substring(0, zipIndex);
            currentMember = currentMember.Substring(zipIndex + separator.Length);
            return zip;
        }

        public int getCountryFromList()   
        {
            int num = 0;
            if (String.Equals(currentMember, "USA"))
                 num = 0;
            if (String.Equals(currentMember, "Sweden"))
                num = 1;
            if (String.Equals(currentMember, "Jamaica"))
                num = 2;
            if (String.Equals(currentMember, "Holland"))
                num = 3;
            if (String.Equals(currentMember, "Spain"))
                num = 4;
            if (String.Equals(currentMember, "Another"))
                num = 5;
       return num;
        }

       


    }
}
