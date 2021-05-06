using System;
using System.Collections.Generic;
using System.Text;

namespace Assign_2
{
    class FloatingNumbersWhileAdd
    {
        private double sum;
        public void start()
        {

            writeProgramInfo();
            readInputAndSumNumbers();
            ShowResult();

        }
        private void writeProgramInfo()
        {
            Console.WriteLine("*** Summation of real numbers using while loop ***");
        }

        private void readInputAndSumNumbers()
        {
            Console.WriteLine("input 0 if you finished");
            Console.WriteLine("_______________________________");

            bool done = false;

            while (!done)
            {
                Console.WriteLine("Input a number to add :");
                double number = double.Parse(Console.ReadLine());

                if (number == 0.0)
                {
                    done = true;
                }
                else
                    sum += number;

            }
        }

     


        private void ShowResult()
        {
            Console.WriteLine("The sum is :" + sum);
        }


    }
}
