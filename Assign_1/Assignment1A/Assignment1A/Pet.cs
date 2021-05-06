using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment1A
{
    class Pet
    {
        private string name;
        private int age;
        private char isFemale;
        public Pet(string name, int age, char isFemale) // constructor to initialize the values 
        {
            this.name = name;
            this.age = age;
            this.isFemale = isFemale;
        }

        public Pet()        //  Empty constructor 
        {

        }


        private bool checkIsFemale()          // check if female method
        {
            if (isFemale == 'y')
            {
                return true;
            }
            return false;
        }

        public void toString()              // print method
        {
            Console.WriteLine("\n_______________________");
            Console.WriteLine("Name :" + name);
            Console.WriteLine("Age :" + age);
            if (checkIsFemale())
            {
                Console.WriteLine("Name :" + name + " is a cute girl ^_^");
                Console.WriteLine("\n_______________________");
                Console.ReadKey();
            }
            else
                Console.WriteLine("Name :" + name + " is a big boy ^_^");
            Console.WriteLine("\n_______________________");
            Console.ReadKey();
        }

        public void start()
        {

            Console.WriteLine("Enter your pet name:");
            name = Console.ReadLine();
            Console.WriteLine("How old is " + name + " :");
            age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Is " + name + "Female [y/n]:");
            isFemale = Console.ReadKey().KeyChar;

            Pet p = new Pet(name, age, isFemale);  // create a new object and initialize the values in the constructor
            p.toString();

        }

    }
}
