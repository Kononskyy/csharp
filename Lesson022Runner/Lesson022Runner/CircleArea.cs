using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson022Runner
{
   public  class CircleArea
    {
        public const double PI = 3.14;

        public static void CalculateBigger()
        {

            Console.WriteLine("Calculate the bigger circle area with using radius");
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("Enter radius for first circle");
            string r1 = Console.ReadLine();
            double radius1 = Convert.ToDouble(r1);

            Console.WriteLine("Enter radius for second circle"); 
            string r2 = Console.ReadLine();
            double radius2 = Convert.ToDouble(r2);

            double area1 = radius1 * radius1 * PI;
            double area2 = radius2 * radius2 * PI;

            if (area1 > area2)
            {
                Console.WriteLine("Circle1 area is bigger");

            }
            else if (area1 == area2)
            {
                Console.WriteLine("Circle1 area is equal to Circle2 area");
            }
            else {
                Console.WriteLine("Circle2 area is bigger");
            }
                        
        }

   }
}
