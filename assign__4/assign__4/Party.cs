using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assign__4
{
    class Party
    {
        private double costPerCapita;
        private string[] guestList;

        public Party(int maxNumOfGuest)
        {
            guestList = new string[maxNumOfGuest];
        }

        public string setFirstName(string first)
        {
            return first;
        }

        public string setLastName(string last)
        {
            return last;
        }


        public bool vacantPlace() // Check if there is a vacantPlace
        {
            bool ok = false;
            for (int i = 0; i < guestList.Length; i++)
            {
                if (string.IsNullOrEmpty(guestList[i]))
                {
                    ok = true;
                }
            }
            return ok;
        }


        public int getIndex() // Method to help us to find the index we will use it in following methods
        {
            int index = 0;
            for (int i = 0; i < guestList.Length; i++)
            {
                if (string.IsNullOrEmpty(guestList[i]))
                {
                    break;
                }
                else
                    index++;
            }
            return index;
        }



        public void addGuest(string first, string last)
        {

            string name = first.ToUpper() + " , " + char.ToUpper(last[0]) + last.Substring(1);
            int num = getIndex();
            guestList[num++] = name;
        }

        public void setCost(double costPer)
        {
            costPerCapita = costPer;
        }
        public double getTotalCost()
        {
            double num = costPerCapita * getIndex();

            return num;
        }

        public string maxNumOfGuest()
        {
            return "The Guests list is full";
        }
        public string[] getList()
        {
            return guestList;
        }

        public string print()
        {

            return guestList[getIndex() - 1];
        }


        public void delteAt(int index)
        {
            guestList[index] = null;
        }

        public string separatorIndex(string str, int index)
        {
            string value = guestList[index];
            string separator = " , ";
            int separatorIndex = guestList[index].IndexOf(separator);
            string first = null;
            string result = null ;
            string lastName = null;
            if (separatorIndex >= 0)
            {
                lastName = value.Substring( separatorIndex+ separator.Length);
                first = value.Substring(0,separatorIndex+1);
                first = str;
                result = first.ToUpper() + separator + lastName;
                guestList[index] = result;
            }
            return result;
        }
    }
    }

  
