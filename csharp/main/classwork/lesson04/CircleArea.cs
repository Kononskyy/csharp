using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp
{
   public  class CircleArea
    {
        public const double PI = 3.14;

        public static double CalculateBigger(double radius1, double radius2)
        {

            double area1 = radius1 * radius1 * PI;
            double area2 = radius2 * radius2 * PI;

            if (area1 > area2)
            {
                Console.WriteLine("Circle1 area is bigger");
                return 1;

            }

            else if (area1 < area2)
            {
                Console.WriteLine("Circle2 area is bigger");
                return 2;
            }

            else if (area1 == area2 && area1 > 0 && area2 > 0)
            {
                Console.WriteLine("Circle1 area is equal to Circle2 area");
                return 0;
            }

            else
            {
                Console.WriteLine("Please, input valid date");
                return 3;

            }

            
                        
        }

   }
}
