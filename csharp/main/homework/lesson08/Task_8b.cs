using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using csharp.main.homework.lesson07;

namespace csharp.main.homework.lesson08
{
    class Task_8b
    {
        public static void Task8b()
        {
            String fromFile = File.ReadAllText(@"D:\Projects\MyWords.txt");
            System.IO.StreamWriter textFile = new System.IO.StreamWriter(@"D:\Projects\MyTestResult2.txt");
            
            string [] result = new string[10];
            string[] reResult = new string[10];

            int i = 0;
            foreach (var word2 in fromFile.Split('\n'))
            {
                foreach (var word in word2.Trim().Split('\n'))
                {
                    //Palindrom aaa = new Palindrom();
                    //bool palindr = aaa.IsPalin(word.Trim()
                    string reverStr = new string(word.Reverse().ToArray());
                    result[i] = word;
                    reResult[i] = reverStr;

                    if (result[i].ToLower().Equals(reResult[i].ToLower()))
                    {
                        Console.WriteLine("String " + result[i] + " is palindrom");
                        textFile.WriteLine("String " + result[i] + " is palindrom");
                        Console.ReadLine();
                    }

                    else
                    {
                        Console.WriteLine("String " + result[i] + " is NOT palindrom");
                        textFile.WriteLine("String " + result[i] + " is NOT palindrom");
                        Console.ReadLine();
                    }                  
                }                         
            }
            i++;
            textFile.Close();
        }
    }
}
