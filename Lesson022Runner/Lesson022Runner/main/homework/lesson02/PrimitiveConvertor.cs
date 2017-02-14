using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson22Runner
{
    class PrimitiveConvertor
    {

        char outputChar1;
        char outputChar2;
        int outputInt;


        public char floatToChar(float inputFloat)
        {
            outputChar1 = (char)inputFloat;


            Console.WriteLine("Input float value is" + inputFloat + ". Output char value is " + outputChar1);
            return outputChar1;
        }

        public char intToChar(int inputInt)
        {
            outputChar2 = (char)inputInt;
            Console.WriteLine("Input float value is" + inputInt + ". Output char value is " + outputChar2);
            return outputChar2;

        }

        public int charToInt(char inputChar3)
        {
            outputInt = (int)inputChar3;
            Console.WriteLine("Input float value is" + inputChar3 + ". Output char value is " + outputInt);
            return outputInt;
            //Console.WriteLine(inputChar);
            //Console.WriteLine("Input float value is" + inputChar + ". Output char value is " + inputInt);
        }
    }


}
