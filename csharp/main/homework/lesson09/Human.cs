using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp.main.homework
{
    public class Human
    {
        private String name;
        private int age;


        /*
       public int GetAge()
       {
           return age;
       }

       public void SetAge(int age)
       {
           if (age >= 1 && age <= 120)
           {
               this.age = age;
               Console.WriteLine("New age setted");
               Console.ReadLine();
           }
           else
           {
               Console.WriteLine("Age invalid");
           }
       }

       public String GetName()
       {
           return name;
       }

       public void SetName(string name)
       {
           this.name = name;
           Console.WriteLine("Name is " + name);
       }

       public Human() { }

       public Human(string name, int age)

       {
          this.SetAge = age;
          this.name = name;
       }

    */

            // Property
        public int Age
       {
           get { return this.age; }
           set
           {
               if (value <= 120 && value >= 1)
               {
                   this.age = value;
                   Console.WriteLine("New age setted");
                   Console.ReadLine();
               }
               else
               {
                   Console.WriteLine("Age invalid");
               }
           }
       }
       public string Name
       {
           get { return this.name; }
           set { this.name = value; }
       }
       public Human() { }
       public Human(string name, int age)
       {
           Age = age;
           Name = name;
       }
       
    }


}

