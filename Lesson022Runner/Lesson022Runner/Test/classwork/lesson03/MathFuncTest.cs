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
        MathFunc mathFunc = new MathFunc();

        [Test]
        public void MultiplyTest() //Method
        {
            int a = 1;
            int b = 2;
            int expRes = 2;
            Assert.AreEqual(expRes, mathFunc.Multi(a, b));

        }

        [Test]
        public void MultiplyTest1()
        {
            int a = 3;
            int b = 3;
            int expRes = 6;
            Assert.AreEqual(expRes, mathFunc.Addition(a, b));

        }
        [Test]
        public void MultiplyTest2()
        {
            int a = 3;
            int b = 3;
            int expRes = 1;
            Assert.AreEqual(expRes, mathFunc.Division(a, b));

        }
        [Test]
        public void MultiplyTest3()
        {
            int a = 3;
            int b = 3;
            int expRes = 0;
            Assert.AreEqual(expRes, mathFunc.Subtraction(a, b));

        }

        [Test]
        public void MaxInt()
        {
            int a = 3;
            int b = 7;
            int expRes = 7;
            Assert.AreEqual(expRes, mathFunc.Max(a, b));

        }

        [Test]
        public void FloorValue()
        {
            decimal a = 3.8m;
            int expRes = 3;
            Assert.AreEqual(expRes, mathFunc.FloorValue(a));

        }

        [Test]
        public void FloorValueNotEqual()
        {
            decimal a = 3.8m;
            int expRes = 4;
            Assert.AreNotEqual(expRes, mathFunc.FloorValue(a));

        }

        [Test]
        public void RoundValue()
        {
            decimal a = 3.8m;
            int expRes = 4;
            Assert.AreEqual(expRes, mathFunc.RoundValue(a));

        }

        [Test]
        public void RoundValueNotEqual()
        {
            decimal a = 306.49m;
            int expRes = 307;
            Assert.AreNotEqual(expRes, mathFunc.RoundValuePass(a));

        }
        
     //   [Test]
     //   public void RoundValuePass()
      //  {
          //  int a = 306;
           // int b = 309;
           // bool expRes = ;
          //  Assert.Pass(expRes, mathFunc.RoundValuePass(a, b));

       // }


    }
}
