using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp
{
    [TestFixture]
    public class CircleRadiusTest
    {
        //WhatIsBigger circleRadius = new WhatIsBigger();

        [Test]
        public void InputWrongR()
        {
            double area = CircleRadius.Calculation(2);
            Assert.AreEqual(12.56, area);
        }

        [Test]
        public void InputWrongR2()
        {
            double area = CircleRadius.Calculation(2);
            Assert.Greater(12.57, area);


         }

        //WhatIsBigger whatIsBigger = new WhatIsBigger();

        [Test]
        public void BiggerNumber1()
        {
            double a = WhatIsBigger.FindBigger(4, 6);
            Assert.AreEqual(2, a);
        }

        [Test]
        public void BiggerNumber2()
        {
            double a = WhatIsBigger.FindBigger(5, 5);
            Assert.AreEqual(0, a);
        }

        [Test]
        public void BiggerNumber3()
        {
            double a = WhatIsBigger.FindBigger(3, 3);
            Assert.AreNotEqual(3, a);
        }

        [Test]
        public void TriangleIs1()
        {
            double corner = Triangle.CalculateTriangle(3, 4, 5);
            Assert.AreEqual(1, corner);
        }

        [Test]
        public void TriangleIs2()
        {
            double corner = Triangle.CalculateTriangle(1.1, 21, 0);
            Assert.IsNotNull(corner);
        }

        [Test]
        public void TriangleIs3()
        {
            double corner = Triangle.CalculateTriangle(0, 0, 0);
            Assert.AreEqual(0, corner);
        }

        [Test]
        public void BiggerCircle1()
        {
            double area = CircleArea.CalculateBigger(5, 4);
            Assert.AreEqual(1, area);
        }

        [Test]
        public void BiggerCircle2()
        {
            double area = CircleArea.CalculateBigger(5, 5);
            Assert.AreNotEqual(1, area);
        }

        [Test]
        public void BiggerCircle3()
        {
            double area = CircleArea.CalculateBigger(0, 5);
            Assert.AreEqual(2, area);
        }

        [Test]
        public void BiggerCircle4()
        {
            double area = CircleArea.CalculateBigger(0, 0);
            Assert.AreEqual(3, area);
        }

       
    }
}
