using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProject1
{
    [TestClass]
    public class CalculatorTest
    {
        [TestMethod]
        public void TestCalculatorAddition()
        {
            float num1 = 5;
            float num2 = 3;
            float expectedResult = num1 + num2;

            float result = PerformCalculation('+', num1, num2);

            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void TestCalculatorDivision()
        {
            float num1 = 10;
            float num2 = 2;
            float expectedResult = num1 / num2;

            float result = PerformCalculation('/', num1, num2);

            Assert.AreEqual(expectedResult, result);
        }

        private float PerformCalculation(char oper, float num1, float num2)
        {
            switch (oper)
            {
                case '+':
                    return num1 + num2;
                case '-':
                    return num1 - num2;
                case '*':
                    return num1 * num2;
                case '/':
                    if (num2 != 0)
                    {
                        return num1 / num2;
                    }
                    else
                    {
                        throw new DivideByZeroException();
                    }
                default:
                    throw new ArgumentException("Invalid operator.");
            }
        }
    }
}
