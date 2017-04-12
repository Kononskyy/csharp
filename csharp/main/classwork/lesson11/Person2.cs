using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp.main.classwork.lesson11
{
    public class Person2
    {
        protected String name;
        public Person2 (String name)
        {
            this.name = name;
        }

        public virtual String GetResponse()
        {
            return "My name is " + name;
        }
    }
}
