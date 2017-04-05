using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp.main.classwork.lesson09
{
    class Bicycle
    {
        private int wheelSize; // polya class-a
        private int freamSize; // polya class-a
        private string color;  // polya class-a

        public Bicycle(int wheelSize, string color)
        {
            this.color = color;
            this.wheelSize = wheelSize;
            //Console.WriteLine(wheelSize + " " + color);
        }

        public Bicycle (int wheelSize)
            : this()
        {
            this.wheelSize = wheelSize;
        }

        public Bicycle(int freamSize, int wheelSize)
            : this()
        {
            this.wheelSize = wheelSize;
            this.freamSize = freamSize;
        }

        public Bicycle()
        {
            wheelSize = 26;
            color = "red";
        }

        public string Ride()
        {
            Console.WriteLine(wheelSize + " " + color);
            Console.WriteLine(wheelSize + " " + freamSize);
            Console.WriteLine(wheelSize + " " + color + " " + freamSize);

            return "Wroom!";
        }


    }
}
