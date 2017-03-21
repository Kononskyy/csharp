using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp.main.homework.lesson06
{
    class Task_2c
    {
        public static void Task2c()
        {
            
            int[] randValue = new int[15];
            Random rand = new Random();
            
            for (int i = 0; i < randValue.Length; i++)
            {
                randValue[i] = rand.Next(10);
                Console.Write(randValue[i] + " ");                
            }

            Console.WriteLine();

            int count = 0;
            foreach (int val in randValue)
            {
                if (val % 2 == 0)
                {
                    count++;                    
                }            
            }
            Console.WriteLine("Number of even is equal = {0}\nNumber of odd is equal = {1}",count , 15 - count);
        }
    }
}
