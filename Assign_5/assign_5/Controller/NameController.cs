
using assign_5.model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assign_5.Controller
{
    public class NameController
    {
        private Person p = new Person();
      


        //public NameController (string firstName, string lastName)
        //{
        //    this.firstName = firstName;
        //    this.lastName = lastName;
        //}


        public void SetFirstName(string first)
        {
            p.FirstName = first;
        }

        public string getFirstName()
        {
            return p.FirstName;
        }

        public void SetLastName(string last)
        {
            p.LastName = last;
        }

        public string getLaststName()
        {
            return p.LastName;
        }



    }
}





