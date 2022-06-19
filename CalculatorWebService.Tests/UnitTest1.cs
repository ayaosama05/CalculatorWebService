using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalculatorWebService.Tests.CalculationsWS;

namespace CalculatorWebService.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void DivideMethod()
        {
            Calculations calculations = new Calculations();
            int res = calculations.DivideNumbers(15, 5);
            Assert.AreEqual(res, 3);
        }

        [TestMethod]
        public void MultipleMethod()
        {
            Calculations calculations = new Calculations();
            int res = calculations.MultiplyNumbers(1, 5);
            Assert.AreEqual(res, 5);
        }

        [TestMethod]
        public void AddMethod()
        {
            Calculations calculations = new Calculations();
            int res = calculations.AddNumbers(10, 20);
            Assert.AreEqual(res, 30);
        }

        [TestMethod]
        public void SubtractMethod()
        {
            Calculations calculations = new Calculations();
            int res = calculations.SubtractNumbers(10, 5);
            Assert.AreEqual(res, 5);
        }
    }
}
