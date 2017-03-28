using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp.main.classwork.lesson08
{
    class WorkWithFile
    {
        public static void WithFile()
        {
            string path = "D:\\Projects\\MyTest1.txt";
            string s = "";
            //path = @ "D:\Projects\MyTest.txt";
            try {
                StreamReader sr = File.OpenText(path);
                while ((s = sr.ReadLine()) != null)
                {
                    Console.WriteLine(s);
                }
                //Console.ReadLine();
            }
            catch (DirectoryNotFoundException e)
            {
                Console.WriteLine("This is an exception msg: " + e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("This is generic method" + e.StackTrace);
            }
            finally
            {
                Console.WriteLine("This is finally block");
                Console.ReadLine();
            }
            }
    }
}
