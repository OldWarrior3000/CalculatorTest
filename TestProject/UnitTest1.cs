using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalculatorTest;

namespace TestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CalculatorAdd()
        {
            Calculator calculator = new Calculator();
            Assert.AreEqual(3, calculator.Add(1, 2));
        }

        [TestMethod]
        public void CalculatorSubstract()
        {
            Calculator calculator = new Calculator();
            Assert.AreEqual(-1, calculator.Substract(1, 2)); //FAIL
        }
    }
}
