using csharp.main.classwork.lesson06;
using csharp.main.classwork.lesson07;
using csharp.main.classwork.lesson08;
using csharp.main.classwork.lesson09;
using csharp.main.classwork.lesson10;
using csharp.main.classwork.lesson11;
using csharp.main.homework;
using csharp.main.homework.lesson06;
using csharp.main.homework.lesson07;
using csharp.main.homework.lesson08;
using csharp.main.homework.lesson09;
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
            Person3 person = new Person3("Ivan", 22);
            Console.WriteLine(person.ToString());
            Console.ReadLine();

            // Pixel pixel = new Pixel(2, 5);
            // int[] pixCoords = pixel.GetCoords();  
            /*
            Student2 student = new Student2("Egor", "KPI");
            Console.WriteLine(student.GetResponse());

            Teacher2 teacher = new Teacher2("Ivan", "NAU");
            Console.WriteLine(teacher.GetResponse());

            Person2 person = new Student2("Ilya", "LNU");
            Console.WriteLine(person.GetResponse());

            person = new Teacher2("Evgen", "HPI");
            Console.WriteLine(person.GetResponse());

            Console.ReadLine();
                  */        

            /*
            NewStudent encapsul = new NewStudent("Sasha", "KPI", "Kyiv", "Fuck");
            Console.ReadLine();

            */
            /*encapsul.SetAge(24);
            encapsul.SetResponse("Aaaaaa");
            encapsul.SetName("Nikolay");
            encapsul.("Nikolay");
            */

            //Console.WriteLine("New student "+ encapsul.name + " Age is " + encapsul.GetAge() + " His mind " + encapsul.GetResponse());


            /*

            Console.WriteLine("Input new Name");
            string newName = Console.ReadLine();
            

            Console.WriteLine("Input new age");
            string fromMenu = Console.ReadLine();
            int newAge = (int)Convert.ToDouble(fromMenu);

            Human newHuman = new Human(newName, newAge);
            

            Console.ReadLine();
            */

            // NewStudent student = new NewStudent("AlarmFuck", "KPI");
            //WhiteCollar white = new WhiteCollar("Sasha", 28, "SBTech");


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
