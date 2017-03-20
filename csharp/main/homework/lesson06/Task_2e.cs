using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp.main.homework.lesson06
{
    class Task_2e
    {
        public static void Task2e()
        {
            int[][] odd = new int[8][];
            for (int i = 0; i < odd.Length; i++)
            {
                odd[i] = new int[5];
            

            Random ramd = new Random();
            
                        odd[k][j] = ramd.Next(10, 99);
                        Console.Write(odd[k][j] + " ");
                    }
                }

                /*

                int j = 0;
            for (int i = 1; i <= 8; i += 1)
            {
                odd[0][j] = ramd.Next(10 , 99);
                Console.Write(odd[0][j] + " ");
                j++;
            }
            Console.WriteLine();

            int k = 0;
            for (int i = 1; i <= 5; i += 1)
            {
                odd[0][k] = ramd.Next(10, 99);
                Console.Write(odd[0][k] + " ");
                k++;


    */
            }
        }
    }

}
