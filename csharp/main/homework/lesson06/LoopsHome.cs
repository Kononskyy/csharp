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

        /*

        
        /*
        ----------------------------------------------
                
            int[][] odd = new int[2][];
            for (int i = 0; i < odd.Length; i++)
            {
                odd[i] = new int[10];

            }

            for (int j = 0; j < 1; j++)
            {
                for (int k = 0; k < 20; k++)
                {
                    if (k % 2 != 0)
                    {
                        //odd[0][k] = (k + 1);
                        //Console.Write(odd[0][k] + " ");
                        odd[j][k] = (k + 1);
                        Console.Write(odd[0][k] + " ");
                        Console.WriteLine(odd[1][k] + " ");
                    }

                }
                Console.WriteLine();
            }
            Console.ReadLine();

            


    */



    }
}
