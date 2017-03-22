﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp.main.homework.lesson06
{
    class Task_2g
    {
        public static void Task2g()
        {
            Console.WriteLine("Array[8,5] with random numbers from 10 to 999 and Right justified: ");
            Console.WriteLine();

            Random rand = new Random();
            string[,] odd = new string[8, 5];            
            for (int j = 0; j <= 7; j++)
            {
                for (int k = 0; k <= 4; k++)
                {
                    int s = rand.Next(10, 999);
                    string num = Convert.ToString(s);
                    odd[j, k] = num.PadLeft(5);
                    Console.Write(odd[j, k] + " ");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
