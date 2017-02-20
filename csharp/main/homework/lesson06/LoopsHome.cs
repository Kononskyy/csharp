using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp.main.homework.lesson06
{
    class LoopsHome
    {
        public static void LoopHome()
        {
            /*for (int i = 2; i <= 20; i += 2)
            {
                Console.WriteLine(i + "\n");
            }
            */
            /*
            for (int i = 2; i <= 20; i += 2)
            {
                int[] a = new int[20];
                a[i - 1] = i;
                Console.WriteLine(a[i - 1] + "\n");

            }


            for (int j = 1; j <= 20; j += 1)
            {

                int[] b = new int[20];
                b[j - 1] = j;
                Console.Write(b[j - 1] + " ");
            }
            */
            
            for (int k = 1; k <= 99; k += 1)
            {
                int[] c = new int[100];
                if (k%2 != 0)
                {
                    c[k - 1] = k;
                    Console.Write(c[k - 1] + " ");
                }
                           
            }
            Console.WriteLine();


            for (int k = 99; k >= 1; k -= 1)
            {
                int[] c = new int[100];
                if (k % 2 != 0)
                {
                    c[100 - k] = k;
                    Console.Write(c[100 - k] + " ");
                }

            }



        }
     }
}
