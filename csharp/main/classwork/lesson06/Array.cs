using csharp.main.homework.lesson06;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp.main.classwork.lesson06
{
    class Array
    {
        public static void ArrayClass()
        {
            /*
            int[] intArray = { 1, 2, 3 };
            for (int i = 0; i < intArray.Length; i++)
            {
                Console.WriteLine(intArray[i]);
                
            }

            Boolean [] intArrayBool = { true, true, false };
            for (int i = 0; i < intArrayBool.Length; i++)
            {
                Console.WriteLine(intArrayBool[i]);
                
            }

            Char [] intArrayChar = { '3', '!', '2' };
            for (int i = 0; i < intArrayChar.Length; i++)
            {
                Console.WriteLine(intArrayChar[i]);
                
            }

            long[] intArrayLong = { 12L, 3L, 88L };
            for (int i = 0; i < intArrayLong.Length; i++)
            {
                Console.WriteLine(intArrayLong[i]);
                
            }

            double[] intArrayDouble = { 12.3, 31.66, 11.11 };
            for (int i = 0; i < intArrayDouble.Length; i++)
            {
                Console.WriteLine(intArrayDouble[i]);
                
            }
            */

            /*
            int [][] intArray = new int [2][ ];
            intArray[0] = new int[3];
            intArray[1] = new int[3];
            */
           
            int[][] intArray = new int[2][];
            for (int i = 0; i < intArray.Length; i++)
            {
                intArray[i] = new int[3];
            }

            for (int j = 0; j < intArray.Length; j++)
            {
                for (int k = 0; k < intArray[j].Length; k++)
                {
                    intArray[j][k] = (j + 1) * (k + 1);
                    Console.Write(intArray[j][k] + " ");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }

        
    }

   

}
    

