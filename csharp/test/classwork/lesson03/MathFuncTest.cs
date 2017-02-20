using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp
{
    [TestFixture]
    class MathFuncTest
    {
        MathFunc mathFunc;
    

    [OneTimeSetUp]
    public void OneTimeSetUp()
    {
        mathFunc = new MathFunc();
    }

    static object[][] multiplyData = {
        new object[] {  12, 3, 36, true},
        new object[] {  12, 2, 24, true},
        new object[] {  12, 3, 25, false}
    };
        static object[][] addition = {
        new object[] {  12, 3, 15, true},
        new object[] {  12, 2, 14, true},
        new object[] {  12, 3, 16, false}
    };
        static object[][] division = {
        new object[] {  12, 3, 4, true},
        new object[] {  12, 2, 6, true},
        new object[] {  12, 3, 16, false}
    };
        static object[][] subtraction = {
        new object[] {  55, 10, 45, true},
        new object[] {  66, 33, 33, true},
        new object[] {  77, 7, 76, false}
    };
        static object[][] maxIntData = {
        new object[] {  55, 10, 55, true},
        new object[] {  66, 33, 66, true},
        new object[] {  77, 7, 76, false}
    };

        static object[][] floorValueData = {
        new object[] {  55.99m, 55, true},
        new object[] {  66.123m, 66, true},
        new object[] {  77.444m, 76, false}
    };

        [Test, TestCaseSource("multiplyData")]
        public void MultiplyTest(int a, int b, int expRes, bool boolResult) //Method
        {
            
            Assert.AreEqual(boolResult, expRes == mathFunc.Multi(a, b));

        }
        

        [Test, TestCaseSource("addition")]
        public void Addition(int a, int b, int expRes, bool boolResult)
        {
            
            Assert.AreEqual(boolResult, expRes == mathFunc.Addition(a, b));

        }
        
        [Test, TestCaseSource("division")]
        public void Division(int a, int b, int expRes, bool boolResult)
        {
           
            Assert.AreEqual(boolResult, expRes == mathFunc.Division(a, b));

        }

        
        [Test, TestCaseSource("subtraction")]
        public void Subtraction(int a, int b, int expRes, bool boolResult)
        {
            
            Assert.AreEqual(boolResult, expRes == mathFunc.Subtraction(a, b));

        }
        
        [Test, TestCaseSource("maxIntData")]
        public void MaxInt(int a, int b, int expRes, bool boolResult)
        {
           
            Assert.AreEqual(boolResult, expRes == mathFunc.Max(a, b));

        }

        

        [Test, TestCaseSource("floorValueData")]
        public void FloorValue(decimal a, int expRes, bool boolResult)
        {
            
            Assert.AreEqual(boolResult, expRes == mathFunc.FloorValue(a));

        }

        /*
        [Test, TestCaseSource("floorValueNotEqualData")]
        public void FloorValueNotEqual()
        {
            //decimal a = 3.8m;
            //int expRes = 4;
            Assert.AreNotEqual(expRes, mathFunc.FloorValue(a));

        }

        [Test, TestCaseSource("roundValueData")]
        public void RoundValue()
        {
            //decimal a = 3.8m;
            //int expRes = 4;
            Assert.AreEqual(expRes, mathFunc.RoundValue(a));

        }

        [Test, TestCaseSource("roundValueNotEqualData")]
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
       */

    }
}
