using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp.main.classwork.lesson09
{
    public class Person
    {
        protected String name;
        protected String city;
        /*public Person(String name, String city)
        {
            this.name = name;
        }
        */
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public string City
        {
            get { return this.city; }
            set { this.city = value; }
        }

        public Person(string name, string city)
        {
            City = city;
            Name = name;
        }
    }
}
