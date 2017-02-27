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
            /*
              //vivod v stroku
            int[] mass = new int[10];
            int j = 0;
            for (int i = 2; i <= 20; i += 2)
            {
                mass[j] = i;
                Console.Write(mass[j] + " ");

            }
            Console.ReadLine();
            */
            /*
            //vivod v stolbec
            int[] mass2 = new int[10];
            int k = 0;
            for (int i = 2; i <= 20; i += 2)
            {
                mass2[k] = i;
                Console.WriteLine(mass2[k] + " ");
            }
            Console.ReadLine();
            }
            */

            int[][] odd = new int[2][];
            for (int i = 0; i < odd.Length; i++)
            {
                odd[i] = new int[50];
            }

            for (int j = 0; j < odd.Length; j++)
            {
                for (int k = 0; k <= 101; k++)
                {
                    if (k % 2 != 0)
                    {
                        odd[j][k] = (1) * (k);
                        Console.Write(odd[j][k] + " ");
                    }
               
                }
                Console.WriteLine();
            }
            Console.ReadLine();

            /*


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

*/


        }
    }
}
