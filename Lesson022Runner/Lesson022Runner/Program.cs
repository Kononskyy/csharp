﻿using Lesson22Runner;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson22Runner
{
    class Program
    {


        public static void Main(string[] args)
        {
            float inpFloat = 77.0F;
            int inpInt = 78;
            char inpChar = '1';


            // Convert from float to Char

            PrimitiveConvertor primitiveConvertor = new PrimitiveConvertor();
            primitiveConvertor.floatToChar(inpFloat);
            Console.ReadLine();


            // Convert from int to Char

            PrimitiveConvertor primitiveConvertor2 = new PrimitiveConvertor();
            primitiveConvertor2.intToChar(inpInt);
            Console.ReadLine();

            // Convert from char to Int
            PrimitiveConvertor primitiveConvertor3 = new PrimitiveConvertor();
            primitiveConvertor3.charToInt(inpChar);
            Console.ReadLine();

        }

    }
}