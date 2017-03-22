using csharp.main.homework.lesson06;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp.main.menus
{
    class MenuTasks
    {
        public static void MenuLesson6()
        {

        beg_input:

            Console.Clear();
            Console.WriteLine("Select appropriate number for selecting menu item and press Enter:");
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* 1 - Displaying array with even numbers in range [2,20] in row and column");
            Console.WriteLine("* 2 - Displaying array with odd numbers in range [1,99] and [99,1]");
            Console.WriteLine("* 3 - Array with 15 random numbers in range [0,9]. Finding count of odd numbers");
            Console.WriteLine("* 4 - Array with 15 random numbers in range [0,999].Finding Min and Max numbers");
            Console.WriteLine("* 5 - Two-dimensional array[8,5] with random numbers in range [10,99]");
            Console.WriteLine("* 6 - Two-dimensional array[8,5] with random numbers in range [10,999]");
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("or select Q and press Enter for exit");


            string fromMenu = Console.ReadLine();

            if (fromMenu == "Q" || fromMenu == "q")
            {
                Environment.Exit(0);
            }
            double menuValue = Convert.ToDouble(fromMenu);

            if (menuValue == 1)
            {
                Task_2a.Task2a();
                Console.ReadLine();
            }

            else if (menuValue == 2)
            {
                Task_2b.Task2b();
                Console.ReadLine();
            }

            else if (menuValue == 3)
            {
                Task_2c.Task2c();
                Console.ReadLine();
            }

            else if (menuValue == 4)
            {
                Task_2d.Task2d();
                Console.ReadLine();
            }

            else if (menuValue == 5)
            {
                Task_2e.Task2e();
                Console.ReadLine();
            }

            else if (menuValue == 6)
            {
                Task_2g.Task2g();
                Console.ReadLine();
            }

            else
            {
                Console.WriteLine("Wrong number. Please enter from 1 to 5");
                Console.ReadLine();                
            }

            goto beg_input;
        }
    }
}