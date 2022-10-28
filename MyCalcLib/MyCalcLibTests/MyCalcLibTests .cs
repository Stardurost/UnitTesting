using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using MyCalcLib;

namespace MyCalcLibTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Sum_10and20_30returned()
        {
            int x = 10, y = 20;
            int expected = 30;

            MyCalc c = new MyCalc();
            int actual = c.Sum(x, y);
            Assert.AreEqual(expected, actual);
        }
    }
}
