using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace InterpreterTests
{
    [TestClass]
    public class InterpreterTests
    {
        [TestMethod]
        public void TestPositiveNumber()
        {
            Assert.AreEqual(2, MathExpressionIntepreter.Evaluate("2"));
        }

        [TestMethod]
        public void TestNegativeNumber()
        {
            Assert.AreEqual(-2, MathExpressionIntepreter.Evaluate("-2"));
        }

        [TestMethod]
        public void TestPrecedence()
        {
            Assert.AreEqual(20, MathExpressionIntepreter.Evaluate("7x3-1"));
        }

        [TestMethod]
        public void TestPrecedenceWithBrackets()
        {
            Assert.AreEqual(14, MathExpressionIntepreter.Evaluate("7x(3-1)"));
        }

        [TestMethod]
        public void TestDivision()
        {
            Assert.AreEqual(0.25, MathExpressionIntepreter.Evaluate("1/4"));
        }
    }
}
