using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ArithmeticOperation;

namespace TestingOperation
{
    [TestClass]
    public class TestOperation
    {
        [TestMethod]
        public void Sum()
        {
            double x = 10, y = 20;
            double expected = 30;

            Arithmetic c = new Arithmetic();
            double actual = c.Sum(x, y);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Sub()
        {
            double x = 50, y = 20;
            double expected = 30;

            Arithmetic c = new Arithmetic();
            double actual = c.Sub(x, y);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Pow()
        {
            double x = 2, y = 5;
            double expected = 32;

            Arithmetic c = new Arithmetic();
            double actual = c.Pow(x, y);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Sqr()
        {
            double x = 32, y = 5;
            double expected = 2;

            Arithmetic c = new Arithmetic();
            double actual = c.Sqr(x, y);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Div()
        {
            int x = 9, y = 4;
            double expected = 2;

            Arithmetic c = new Arithmetic();
            double actual = c.Div(x, y);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Mod()
        {
            int x = 9, y = 4;
            double expected = 25;

            Arithmetic c = new Arithmetic();
            double actual = c.Mod(x, y);
            Assert.AreEqual(expected, actual);
        }
    }
}
