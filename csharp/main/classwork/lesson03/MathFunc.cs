using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson022Runner
{
    class MathFunc
    {
        public int Multi(int a, int b)
        {
            return a * b;
        }

        public int Addition(int a, int b)
        {
            return a + b;
        }

        public int Division(int a, int b)
        {
            return a / b;
        }

        public int Subtraction(int a, int b)
        {
            return a - b;
        }

        public int Max(int a, int b)
        {
            return Math.Max(a, b);
        }

        public decimal FloorValue(decimal a)
        {
            return Math.Floor(a);
        }

        public decimal FloorValueNotequal(decimal a)
        {
            return Math.Floor(a);
        }

        public decimal RoundValue(decimal a)
        {
            return Math.Round(a);
        }

        public decimal RoundValuePass(decimal a)
        {
            return Math.Round(a);
        }

        public bool RoundValuePass(int a, int b)
        {
            return a > b;
        }







    }
}
