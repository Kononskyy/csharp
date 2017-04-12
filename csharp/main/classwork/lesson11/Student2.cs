using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp.main.classwork.lesson11
{
    public class Student2 : Person2
    {
        private String university;
        private String response = "Ehhh what";
        public readonly double pi = 3.14;
        public Student2(String name, String university)
            : base(name)
        {
            this.university = university;
        }
        public override String GetResponse()
        {
            return response;
        }
    }
}
