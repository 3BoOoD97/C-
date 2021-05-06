using System;
using System.Collections.Generic;
using System.Text;

namespace Assign_2
{
    class CurrencyConverter
    {
        private decimal sumBefore;
        private decimal sumAfter;
        private decimal cRate;
        private string cName;
        public void start()
        {
            writeProgramInfo();
            convertCurrency();
            ShowResult();
        }
        private void writeProgramInfo()
        {
            Console.WriteLine("*** Currency converter using do-while loop ***");
        }

        private void convertCurrency()
        {
            bool done = false;

            do
            {
                Console.WriteLine("Input amount to add :");
                decimal number = decimal.Parse(Console.ReadLine());

                if (number == 0)
                {
                    done = true;
                }
                else
                    sumBefore += number;
            }
            while (!done);
            
            Console.WriteLine("Currency name :");
            cName = Console.ReadLine();
            Console.WriteLine("Currency Rate:");
             cRate = decimal.Parse(Console.ReadLine());
            sumAfter = sumBefore / cRate;        
        }


        private void ShowResult()
        {
            Console.WriteLine("___________________________________________________________________");
            Console.WriteLine("The sum is :" + sumBefore.ToString("0.##"));
            Console.WriteLine(sumBefore.ToString("0.##") + " KR is converted to "+ sumAfter.ToString("0.##") + cName + " at the rate of "+ cRate+" KR / "+cName);
        }


    }
}
