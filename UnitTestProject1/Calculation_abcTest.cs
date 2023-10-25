using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using WindowsFormsApp1.Prakt3;

namespace UnitTestProject1
{
    [TestClass]
    public class Calculation_abcTest
    {
        [TestMethod]
        public void Calculation_all_neparne()
        {
            var calc = new Calculation_abc(3, 7, 9);
            var testRes = 19;
            var res = calc.D();
            Assert.AreEqual(testRes, res);
        }

        [TestMethod]
        public void Calculation_other_way()
        {
            var calc = new Calculation_abc(2, 4, 6);
            var testRes = 4;
            var res = calc.D();
            Assert.AreEqual(testRes, res);
        }

    }
}
