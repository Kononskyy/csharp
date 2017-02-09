using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson022Runner
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
                return;
            }

            double menuValue = Convert.ToDouble(fromMenu);


            if (menuValue == 1)
            {
                CircleArea.CalculateBigger();
                Console.ReadLine();
            }

            else if (menuValue == 2)
            {
                Triangle.CalculateTriangle();
                Console.ReadLine();
            }

            else if (menuValue == 3)
            {
                CircleRadius.Calculation();
                Console.ReadLine();
            }

            else if (menuValue == 4)
            {
                WhatIsBigger.FindBigger();
                Console.ReadLine();
            }

            goto beg_input;
                
        }
    }
}
