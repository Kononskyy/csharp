using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp.main.homework.lesson06
{
    class Task_2d
    {
        public static void Task2d()
        {

            int[] randValue = new int[15];
            Random rand = new Random();

            for (int i = 0; i < randValue.Length; i++)
            {
                randValue[i] = rand.Next(0, 999);
                Console.Write(randValue[i] + " ");
            }
            Console.WriteLine();

            int maxValue = 0;
            int minValue = 999;
            foreach (int val in randValue)
            {                
                if (maxValue < val )
                {
                    maxValue = val;                   
                }
                else if (minValue > val)
                {
                    minValue = val;
                }       
            }
      
            //int maxValue = randValue.Max();
            //int minValue = randValue.Min();
            Console.Write("Max value is equal = {0}\nMin value is equal = {1}", maxValue, minValue);
            
        }
            
     }
}

