using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp.main.classwork.lesson06
{
    class Loop
    {
        public static void LoopFirst()
        {
            /*Console.WriteLine("Input value1");
            string a = Console.ReadLine();
            double val1 = Convert.ToDouble(a);

            Console.WriteLine("Input value2");
            string b = Console.ReadLine();
            double val2 = Convert.ToDouble(b);

             {
                 do
                 {                    
                     Console.WriteLine("a= " + val1);
                     Console.WriteLine("B= " + val2); ;
                     val1 = val1 - 1;
                 } while (val1 >= val2);


             } 
             for (int i = 0; i <= 10; i++)
             {
                 Console.Write(i + " ");
             }           
         

            int a = 1;
            Console.WriteLine("Original a value " + a);
            Console.WriteLine("Post-increment a " + a++);
            Console.WriteLine("After Post-increment " + a);
            Console.WriteLine("Pre increment a " + ++a);
            Console.WriteLine("After pre-increment " + a);
            }*/

            int count = 0;
            for (int i = 0; i <= 20; i = i + 2)
            {
                count++;
            }
            Console.WriteLine("count" + count);
        }
    }
}
