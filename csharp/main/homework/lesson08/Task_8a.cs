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
            string path = "D:\\Projects\\MyTest.txt";
            string s = " ";
            //path = @ "D:\Projects\MyTest.txt";
            StreamReader sr = File.OpenText(path);
            s = sr.ReadLine();
            char[] dam = {','};
            String[] ss = s.Split(dam);
            Array.Sort(ss);
            Console.Write(ss);
            //char[] fromString = (string)ss.ToCharArray();
            
            for (int i = 0; i < ss.Length; i++)
                {               
                    Console.WriteLine(" " + ss[i]);
                }
                        
        }
    }
}