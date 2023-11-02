using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Prakt4;
using System.Runtime.Remoting.Messaging;

namespace UnitTestSolid
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        public void TestMethod1()
        {
            var arrayAB = new ArrayAB(100);
            arrayAB.a = new int[] { 1, 2, 3, 5, 6, 44, 8, 9 };
            arrayAB.Length = 8;
            arrayAB.Calc();
            CollectionAssert.AreEqual(arrayAB.b, new int[] { 1, 2, 3, 5, 6, 8, 9, 44 });
        }

        [TestMethod]
        public void TestMethod2()
        {
            var arrayAB = new ArrayAB(100);
            arrayAB.a = new int[] { 1, 2, 3, 44, 5, 6, 44, 8, 9 };
            arrayAB.Length = 9;
            arrayAB.Calc();
            CollectionAssert.AreEqual(arrayAB.b, new int[] { 1, 2, 3, 5, 6, 8, 9, 44, 44 });
        }



    }
}
