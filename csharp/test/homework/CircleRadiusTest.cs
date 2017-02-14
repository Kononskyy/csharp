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
        WhatIsBigger circleRadius = new WhatIsBigger();

        [Test]
        public void InputWrongR()
        {
            double area = CircleRadius.Calculation(2);
            Assert.AreEqual(12.56, area);
        }

        WhatIsBigger whatIsBigger = new WhatIsBigger();

        [Test]
        public void BiggerNumber()
        {
            double a = WhatIsBigger.FindBigger(4, 6);
            Assert.AreEqual(2, a);
        }

        [Test]
        public void TriangleIs()
        {
            double corner = Triangle.CalculateTriangle(3, 4, 5);
            Assert.AreEqual(1, corner);
        }

        [Test]
        public void BiggerCircle()
        {
            double area = CircleArea.CalculateBigger(5, 4);
            Assert.AreEqual(1, area);
        }

    }
}
