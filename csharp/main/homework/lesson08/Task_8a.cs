using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp.main.homework.lesson08
{
    class Task_8a
    {
        public static void Task8a()
        {            
            String input = File.ReadAllText(@"D:\Projects\MyTest1.txt");
            System.IO.StreamWriter textFile = new System.IO.StreamWriter(@"D:\Projects\MyTestResult.txt");
            
            int i = 0, j = 0;
            int[,] result = new int[10, 10];
            foreach (var row in input.Split('\n'))
            {
                j = 0;
                foreach (var col in row.Trim().Split(','))
                {
                    result[i, j] = int.Parse(col.Trim());                    
                    j++;                    
                }                
                i++;                
            } 
                     
            textFile.Write(input + " ");
            textFile.Close();
            //Array.Sort(ss);
            Console.Write(input);
            Console.ReadLine();    
        }
    }
}