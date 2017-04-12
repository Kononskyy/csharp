using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp.main.classwork.lesson11
{
    class Teacher2 : Person2
    {
        private String university;
        public Teacher2(String name, String university)
            : base(name)
        {
            this.university = university;
        }
        public String LessonFinished()
        {
            return "Do not forget to make homework!";
        }
    }
}
