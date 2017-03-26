using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp.main.homework.lesson07
{
    class Palindrom
    {
        public static void Palindr()
        {
            beg_input:

            Console.Clear();
            Console.WriteLine("Input any word and press Enter");
            Console.WriteLine("or press Q and Enter for exit");
            Console.WriteLine();
            string fromDisplay1 = Console.ReadLine();

            if (fromDisplay1 == "Q" || fromDisplay1 == "q")
            {
                Environment.Exit(0);
            }
            
            string fromDisplay = fromDisplay1.ToUpper();
            char[] fromString = fromDisplay.ToCharArray();
            Array.Reverse(fromString);
            string reverseString = new string(fromString);

            if (fromDisplay == reverseString)
            {
                Console.WriteLine("String " + fromDisplay1 + " is palindrom(method1)");
                Console.ReadLine();
            }        
              
            else
            {
                Console.WriteLine("String " + fromDisplay1 + "is NOT palindrom(method1)");
                Console.ReadLine();
            }
            //***************************************************************************

            Console.WriteLine();
            string reverStr = new string(fromDisplay1.Reverse().ToArray());
            if (fromDisplay1.ToLower() == reverStr.ToLower())
            {
                Console.WriteLine("String " + fromDisplay1 + " is palindrom(method2)");
                Console.ReadLine();
            }

            else
            {
                Console.WriteLine("String " + fromDisplay1 + " is NOT palindrom(method2)");
                Console.ReadLine();
            }
            //***************************************************************************

            string fromDisplay2 = fromDisplay1.ToLower(); //приводим к нижнему регистру всю строку
            int i = 0;
            int j = fromDisplay2.Length - 1;
            while (i < j)
            {
                if (fromDisplay2[i++] != fromDisplay2[j--])
                {
                    Console.WriteLine("String " + fromDisplay1 + " is NOT palindrom(method3)");
                    Console.ReadLine();
                }
            }
            Console.WriteLine("String " + fromDisplay1 + " is palindrom(method3)");
            Console.ReadLine(); ; //если мы добрались сюда, значит палиндром

            goto beg_input;
        }
        
    }
}
