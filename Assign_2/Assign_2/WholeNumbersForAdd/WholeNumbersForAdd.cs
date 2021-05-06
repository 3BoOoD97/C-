using System;
using System.Collections.Generic;
using System.Text;

namespace Assign_2
{
    class WholeNumbersForAdd
    {
        private int sum;
        private int choice;
       
        public void start()
        {
            programInfo();
            readInput();
            sumNumbers();
            showResult();
        }
        
        
        private void readInput()
        {
            Console.WriteLine("Number of whole numbers for add ?");
            int choice = int.Parse(Console.ReadLine());
            this.choice = choice;
        }

        private void sumNumbers()
        {
            
            for (int i = 0; i < choice; i++)
            {
                Console.WriteLine("Please give a value number no" + choice + "(WHOLE NUMBER)");
                int input = int.Parse(Console.ReadLine());
                sum += input;
            }
        }


        private void showResult()
        {
            Console.WriteLine("The sum is :" + sum);
        }

        private void programInfo()
        {
            Console.WriteLine("***** Summation of whole numbers using for-statement *****");
        }




    }
}
