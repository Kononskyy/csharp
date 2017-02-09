using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson022Runner
{
    class WhatIsBigger
    {
        public static void FindBigger()
        {

            Console.WriteLine("Deffining the bigger number");
            Console.WriteLine("---------------------------");

            Console.WriteLine("Enter number a");
            string a = Console.ReadLine();
            double val1 = Convert.ToDouble(a);

            Console.WriteLine("Enter number b");
            string b = Console.ReadLine();
            double val2 = Convert.ToDouble(b);

            if (val1 > val2)
            {
                Console.WriteLine("Number a is bigger");

            }
            else if (val1 == val2)
            {
                Console.WriteLine("Numbers are eaqual");
            }
            else if (val1 < val2)
            {
                Console.WriteLine("Number b is bigger");
            }
           
         }


      }
}
