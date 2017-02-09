using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson022Runner
{
    class DefineNumber
    {
        public static void IsEven()
        {

            Console.WriteLine("Enter any val");

            string val = Console.ReadLine();
            double val1 = Convert.ToDouble(val);

            if ((int)val1 / 2 == val1 / 2)
            {
                //return true;
                Console.WriteLine("evel");
            }


            else
            {
               // return false;
                Console.WriteLine("digit");
            }
        }
    }
}
     