using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp.main.homework.lesson08
{
    class Task_8c
    {
        public static void Task8c()
        {
            System.IO.StreamWriter textFile = new System.IO.StreamWriter(@"D:\Projects\MyTestResult3.txt");
            bool exit = false;
            while (!exit)
            {
                //Console.Clear();
                Console.WriteLine();
                Console.WriteLine("Type any text or Exit word for exit from app ");
                Console.WriteLine();

                String fromDisp = Console.ReadLine();
                if (fromDisp == "Exit" || fromDisp == "exit")
                {
                    exit = true;
                }
                else
                {
                    textFile.WriteLine(fromDisp);
                }
            }
            textFile.Close();
        }
    }
}
