﻿using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp.main.classwork.lesson05
{
    class ParametrizedTests
    {
        static int[][] divideCases =
        {
            new int[] {12, 3, 4},
            new int[] {12, 2, 6},
            new int[] {12, 4, 3}
        };

        [TestCaseSource("divideCases")]
        public void DivideTest(int n, int d, int q)
        {
            Assert.AreEqual(q, n / d);
        }
    }
}
