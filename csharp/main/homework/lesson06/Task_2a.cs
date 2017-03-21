using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp.main.homework.lesson06
{
    class Task_2a
    {
        public static void Task2a()
        {            
            int[] mass = new int[10];
            int j = 0;
            for (int i = 2; i <= 20; i += 2)
            {
                mass[j] = i;
                j++;
            }
            //vivod v stroku
            foreach (int val1 in mass) 
            {
                Console.Write(val1 + " ");
            }
            Console.WriteLine();
            //vivod v stolbec
            foreach (int val1 in mass)
            {                
                Console.WriteLine(val1 + "\n");
            }
        }
    }
}
