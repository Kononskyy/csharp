using csharp.main.classwork.lesson06;
using csharp.main.classwork.lesson07;
using csharp.main.classwork.lesson08;
using csharp.main.classwork.lesson09;
using csharp.main.homework;
using csharp.main.homework.lesson06;
using csharp.main.homework.lesson07;
using csharp.main.homework.lesson08;
using csharp.main.menus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
            Student encapsul = new Student();
            encapsul.SetAge(24);
            encapsul.SetResponse("Aaaaaa");
            encapsul.SetName("Nikolay");

            Console.WriteLine("New student "+ encapsul.GetName() + " Age is " + encapsul.GetAge() + " His mind " + encapsul.GetResponse());
            Console.ReadLine();
            */
            /*

            Console.WriteLine("Input new Name");
            string newName = Console.ReadLine();
            

            Console.WriteLine("Input new age");
            string fromMenu = Console.ReadLine();
            int newAge = (int)Convert.ToDouble(fromMenu);

            Human newHuman = new Human(newName, newAge);
            

            Console.ReadLine();
            */

            NewStudent student = new NewStudent("AlarmFuck", "KPI");


            //Console.WriteLine("Age is " );
            //Console.ReadLine();

            //ThrowExcep fex = new ThrowExcep();
            /*
            try
            {
                ThrowExcep.GetNumber(6);
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }
            finally {
                Console.ReadLine();
            }
           
    */
            /*
                    Bicycle bicycle = new Bicycle();
                    bicycle.Ride();

                    bicycle = new Bicycle(28);
                    bicycle.Ride();

                    bicycle = new Bicycle(24, "green");
                    bicycle.Ride();

                    bicycle = new Bicycle(24, 1);
                    bicycle.Ride();

                    Console.ReadLine();

            */
            //WorkWithFile.WithFile();

            //Console.ReadLine();
            //Task_8a.Task8a();
            //Console.ReadKey();

            //Task_8c.Task8c();
            //Console.ReadKey();



            //Palindrom.Palindr();
            //Console.ReadLine();

            //StartStr.StartString();
            //Console.ReadLine();

            //MenuTasks.MenuLesson6();
            // Console.ReadLine();


            //Menu.FirstMenu();
            //Console.ReadLine();



        }
    }
}
