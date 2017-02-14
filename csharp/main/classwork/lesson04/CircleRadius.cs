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

        //static double circleArea;

        public static double Calculation(double radius)
        {
                  
            double circleArea = PI * radius * radius;
            //Console.WriteLine(circleArea);
            //Console.ReadLine();
            return circleArea;

            }
    } 
}
