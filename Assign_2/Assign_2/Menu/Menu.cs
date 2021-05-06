using System;
using System.Collections.Generic;
using System.Text;

namespace Assign_2
{
    class Menu
    {
        public void start()
        {
            for (int i = 0; i >= 0; i++)   //  loop to repeat the menu
            {
            Console.WriteLine("  ************ MAIN MENU *********");
            Console.WriteLine("1-  Whole Numbers With For");
            Console.WriteLine("2-  Floating Points Numbers With While");
            Console.WriteLine("3-  Currency Convert With Do While");
            Console.WriteLine("4-  Exit");
            Console.WriteLine("   *******************************");

                int choice = int.Parse(Console.ReadLine());

            
                switch (choice)   
                {
                    case 1:
                        {
                            WholeNumbersForAdd obj = new WholeNumbersForAdd();
                            obj.start();
                            break;
                        }
                    case 2:
                        {
                            FloatingNumbersWhileAdd obj = new FloatingNumbersWhileAdd();
                            obj.start();
                            break;
                        }
                    case 3:
                        {
                            CurrencyConverter obj = new CurrencyConverter();
                            obj.start();
                            break;
                        }

                    case 4:
                        Console.WriteLine("GOOD BYE :)");
                        i = -2;
                        break;

                    default:
                        Console.WriteLine("INVALID INPUT, PLEASE TRY AGAIN");
                        break;
                }
            }
        }







    }
}
