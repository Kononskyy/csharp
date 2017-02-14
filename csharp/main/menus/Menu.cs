using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp
{
    class Menu
    {

       public static void FirstMenu() { 

        beg_input:

            Console.Clear();
            Console.WriteLine("Select appropriate number for selecting menu item and press Enter:");
            Console.WriteLine("******************************************************************");
            Console.WriteLine("* 1 - Calculate the bigger circle area with using radius");
            Console.WriteLine("* 2 - Check that  triangle is right-angled");
            Console.WriteLine("* 3 - Calculation circle area");
            Console.WriteLine("* 4 - Deffining the bigger number");
            Console.WriteLine("******************************************************************");
            Console.WriteLine("or select Q and press Enter for exit");


            string fromMenu = Console.ReadLine();

            if (fromMenu == "Q" || fromMenu == "q")
            {
                Environment.Exit(0);
            }
           
            double menuValue = Convert.ToDouble(fromMenu);

            if (menuValue == 1)
            {
                Console.WriteLine("Calculate the bigger circle area with using radius");
                Console.WriteLine("--------------------------------------------------");

                Console.WriteLine("Enter radius for first circle");
                string r1 = Console.ReadLine();
                double radius1 = Convert.ToDouble(r1);

                Console.WriteLine("Enter radius for second circle");
                string r2 = Console.ReadLine();
                double radius2 = Convert.ToDouble(r2);
               
                CircleArea.CalculateBigger(radius1, radius2);
                Console.ReadLine();
            }

            else if (menuValue == 2)
            {
                Console.WriteLine("Check that  triangle is right-angled");
                Console.WriteLine("------------------------------------");

                Console.WriteLine("Enter catet a");
                string a = Console.ReadLine();
                double cateta = Convert.ToDouble(a);

                Console.WriteLine("Enter catet b");
                string b = Console.ReadLine();
                double catetb = Convert.ToDouble(b);

                Console.WriteLine("Enter catet c");
                string c = Console.ReadLine();
                double catetc = Convert.ToDouble(c);


                Triangle.CalculateTriangle(cateta, catetb, catetc);
                Console.ReadLine();
            }

            else if (menuValue == 3)
            {
                Console.WriteLine(" Calculation circle area");
                Console.WriteLine("------------------------");
                Console.WriteLine("Input radius");

                string a = Console.ReadLine();

                //Regex reg = new Regex("[0-9].*$");
                // if (!reg.IsMatch(a))
                //{ }

                double radius = Convert.ToDouble(a);
                Console.WriteLine(CircleRadius.Calculation(radius));
                Console.ReadLine();                
            } 

            else if (menuValue == 4)
            {

                Console.WriteLine("Deffining the bigger number");
                Console.WriteLine("---------------------------");

                Console.WriteLine("Enter number a");
                string a = Console.ReadLine();
                double val1 = Convert.ToDouble(a);

                Console.WriteLine("Enter number b");
                string b = Console.ReadLine();
                double val2 = Convert.ToDouble(b);
                

                WhatIsBigger.FindBigger(val1, val2);
                Console.ReadLine();
            }

            else
            {
                Console.WriteLine("Wrong number. Please enter from 1 to 4");
                Console.ReadLine();
                
            }
            goto beg_input;
                
        }
    }
}
