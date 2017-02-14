using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp
{
    class Triangle
    {
        public static double CalculateTriangle(double cateta, double catetb, double catetc)
        {
            
            
            if ((catetc * catetc == cateta * cateta + catetb * catetb || cateta * cateta == catetb * catetb + catetc * catetc || catetb * catetb == cateta * cateta + catetc * catetc) && cateta > 0 && catetb > 0 && catetc > 0)
            {
                Console.WriteLine("Corner is equal to 90 deg");
                return 1;

            }
            
            else
            {
                Console.WriteLine("Corner is NOT equal to 90 deg");
                return 0;
            }

        }
    }
        
}
