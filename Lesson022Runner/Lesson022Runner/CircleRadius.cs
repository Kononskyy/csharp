using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Lesson022Runner
{
    public class CircleRadius
    {
        public const double PI = 3.14;

        static double radius, circleArea;

        public static void Calculation()
        {
            Console.WriteLine(" Calculation circle area");
            Console.WriteLine("------------------------");
            Console.WriteLine("Input radius");

            string a = Console.ReadLine();
            
            //Regex reg = new Regex("[0-9].*$");
           // if (!reg.IsMatch(a))
            //{

           // }

            radius = Convert.ToDouble(a);
            
            circleArea = PI * radius * radius;
            Console.WriteLine("Area is " + circleArea);
            Console.ReadLine();
        }
    }
}
