using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp.main.classwork.lesson07
{
    class StartStr
    {
        public static void StartString()
        {
            String strToDisplay = "";
            char[] charArrayToString = { 'a', 'b', 'c', 'd' };
            for (int i = 0; i< charArrayToString.Length; i++)
            {
                strToDisplay += charArrayToString[i];
            }
            Console.WriteLine(strToDisplay);

            double dot = 1000.002;
            String display = Convert.ToString(dot);

            String cifra = "10.44";
            double fin = (float)Convert.ToDouble(cifra);

            Console.WriteLine(fin);







            /*
             
            string strObj = "THis is a TEST";
            string s = "This is another TEST";
            if (s == strObj)
            {
                Console.WriteLine("Same");
            }
            else
            {
                Console.WriteLine("Different");
            }

            string newString = s + strObj;
            Console.WriteLine("s + strObj = {0}", newString);

            for (int k = 0; k < s.Length; k++)
            {
                Console.WriteLine("Char" + " " + "{0} is {1}", k, s[k]);
            }
            */

        }
    }
}
