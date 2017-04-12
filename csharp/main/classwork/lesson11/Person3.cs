using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp.main.classwork.lesson11
{
    class Person3
    {
        protected String name;
        protected int age;
        public Person3 (String name)
        {
            this.name = name;
        }

        public Person3 (String name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public virtual String GetResponse(String q)
        {
            return "My name is " + q;
        }
        
        public override string ToString()
        {
            return "Person name is " + name + " and age is " + age;
        }
    }
}
