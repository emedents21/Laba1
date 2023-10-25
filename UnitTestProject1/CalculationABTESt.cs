using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using WindowsFormsApp1.Prakt3;

namespace UnitTestProject1
{
    [TestClass]
    public class CalculationABTESt
    {
        [TestMethod]
        public void Calculation_first()
        {
            var calc = new CalculationAB(2, 1);
            Assert.ThrowsException<System.ArgumentOutOfRangeException>(() => calc.Sun());
        }

        [TestMethod]
        public void Calculation_second()
        {
            var calc = new CalculationAB(1, 1);
            var testRes = 0;
            var res = calc.Sun(); 
            Assert.AreEqual(testRes, res);
        }

        [TestMethod]
        public void Calculation_third()
        {
            var calc = new CalculationAB(-100, 100);
            var testRes = 3;
            var res = calc.Sun();
            Assert.AreEqual(testRes, res);
        }
    }
}
