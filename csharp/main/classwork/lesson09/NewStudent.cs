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

        public NewStudent(String name, String university)
            : base(name)
        {
            this.university = university;
        }
        public String GetResponse()
        {
            Console.WriteLine("aaaaa");
            return response;
        }
    }
   
}
