using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp.main.classwork.lesson09
{
    public class NewStudent : Person
    {
        private String university;
        private String response = "fuck fuck fuuuuck!";
        

        public NewStudent(String name, String university, String city, String response)
            : base(name, city)
        {
            this.university = university;
            Console.WriteLine( "New student name is " + name +". He is from " + city + " and will be studed in " + university + ". It will be " + response);
        }
        public String GetResponse()
        {
            Console.WriteLine("aaaaa");
            return response;
        }
        

    }
   
}
