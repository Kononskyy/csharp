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
            Console.WriteLine("Array[8,5] with random numbers from 10 to 99: ");
            Console.WriteLine();
            int[,] odd = new int[8,5];
            Random rand = new Random();
            for (int j = 0; j <= 7; j++)
            {
                for (int k = 0; k <= 4; k++)
                {
                    odd[j, k] = rand.Next(10, 99);
                    Console.Write(odd[j,k] + "\t");                    
                }
                Console.WriteLine();
            }
            Console.ReadLine();      

        }
    }
}
