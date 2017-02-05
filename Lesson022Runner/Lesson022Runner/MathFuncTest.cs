using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson022Runner
{
    [TestFixture]
    public class MathFuncTest
    {
        [Test]
        public void MultiplyTest() //Method
        {
            int a = 1;
            int b = 2;
            int expRes = 2;
            MathFunc mathFunc = new MathFunc(); //Variable
           
            Assert.AreEqual(expRes, mathFunc.Multi(a, b));

        }

        [Test]
        public void MultiplyTest1()
        {
            int a = 3;
            int b = 3;
            int expRes = 6;
            MathFunc mathFunc = new MathFunc();

            Assert.AreEqual(expRes, mathFunc.Addition(a, b));

        }
        [Test]
        public void MultiplyTest2()
        {
            int a = 3;
            int b = 3;
            int expRes = 1;
            MathFunc mathFunc = new MathFunc();

            Assert.AreEqual(expRes, mathFunc.Division(a, b));

        }
        [Test]
        public void MultiplyTest3()
        {
            int a = 3;
            int b = 3;
            int expRes = 0;
            MathFunc mathFunc = new MathFunc();

            Assert.AreEqual(expRes, mathFunc.Subtraction(a, b));

        }
    }

}
