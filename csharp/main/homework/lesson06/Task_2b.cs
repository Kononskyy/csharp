using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp.main.homework.lesson06
{
    class Task_2b
    {
        public static void Task2b()
        {
             int[] odd = new int[50];

             int j = 0;
             for (int i = 1; i <= 99; i += 2)
             {
                 odd[j] = i;
                 Console.Write(odd[j] + " ");
                 j++;
             }
             Console.WriteLine();

             int k = 0;
             for (int i = 99; i >= 1; i -= 2)
             {
                 odd[k] = i;
                 Console.Write(odd[k] + " ");
                 k++;
             }
             /*
            int[][] odd = new int[2][];
            odd[0] = new int[50];
            odd[1] = new int[50];
            int j = 0;
            for (int i = 1; i <= 99; i += 2)
            {
                odd[0][j] = i;
                Console.Write(odd[0][j] + " ");
                j++;
            }
            Console.WriteLine();

            int k = 0;
            for (int i = 99; i > 1; i -= 2)
            {
                odd[1][k] = i;
                Console.Write(odd[1][k] + " ");
                k++;
            }            
            */
        }
    }
}
