using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson022Runner
{
    class Triangle
    {
        public static void CalculateTriangle()
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

            
            if ((catetc * catetc == cateta * cateta + catetb * catetb || cateta * cateta == catetb * catetb + catetc * catetc || catetb * catetb == cateta * cateta + catetc * catetc) && cateta > 0 && catetb > 0 && catetc > 0)
            {
                Console.WriteLine("Corner is equal to 90 deg");

            }
            //else if (catetc * cateta * catetb == 0)
            //{
            //    Console.WriteLine("Corner is NOT equal to 90 deg");
            // }

            else
            {
                Console.WriteLine("Corner is NOT equal to 90 deg");
            }





        }
    }
        


}
