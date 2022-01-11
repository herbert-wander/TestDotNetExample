using Microsoft.VisualStudio.TestTools.UnitTesting;
using AppTestCode;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppTestCode.Tests
{
    [TestClass()]
    public class CalculatorTests
    {
        [TestMethod()]
        public void SumTest()
        {
            double testNumberA = 5;
            double testNumberB = 5;
            double expectedResult = 10;
            Calculator calculator = new Calculator();
            double resultTest = calculator.Sum(testNumberA, testNumberB);
            Assert.AreEqual(expectedResult,resultTest);
        }

        [TestMethod()]
        public void SubtractTest()
        {
            double testNumberA = 5;
            double testNumberB = 5;
            double expectedResult = 0;
            Calculator calculator = new Calculator();
            double resultTest = calculator.Subtract(testNumberA, testNumberB);
            Assert.AreEqual(expectedResult, resultTest);
        }

        [TestMethod()]
        public void DivideTest()
        {
            double testNumberA = 5;
            double testNumberB = 5;
            double expectedResult = 1;
            Calculator calculator = new Calculator();
            double resultTest = calculator.Divide(testNumberA, testNumberB);
            Assert.AreEqual(expectedResult, resultTest);
        }

        [TestMethod()]
        public void MultiplyTest()
        {
            double testNumberA = 5;
            double testNumberB = 5;
            double expectedResult = 25;
            Calculator calculator = new Calculator();
            double resultTest = calculator.Multiply(testNumberA, testNumberB);
            Assert.AreEqual(expectedResult, resultTest);
        }
    }
}