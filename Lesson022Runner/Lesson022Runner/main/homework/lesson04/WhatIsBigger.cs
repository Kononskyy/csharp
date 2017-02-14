using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson022Runner
{
    class WhatIsBigger
    {
        public static int FindBigger(double val1, double val2)
        {
            if (val1 > val2)
            {
                Console.WriteLine("Number a is bigger");
                return 1;
            }
            
            else if (val1 < val2)

            {
                Console.WriteLine("Number b is bigger");
                return 2;
            }

            else
            {
                Console.WriteLine("Numbers are eaqual");
                return 0;
            }
                       
          }
        
      }
}
