using NUnit.Framework;
using System;

namespace Module._16.UnitTesting.Tests
{
    [TestFixture]
    class CalculatorTests
    {
        [Test]
        public void Subtraction_MustReturnCorrectValue()
        {
            Calculator calculator = new Calculator();
            Assert.That(calculator.Subtraction(300, 10) == 290);
        }

        [Test]
        public void Division_MustReturnCorrectValue()
        {
            Calculator calculator = new Calculator();
            Assert.That(calculator.Division(10, 5) == 2);
        }

        [Test]
        public void Division_MustThrowException()
        {
            Calculator calculator = new Calculator();
            Assert.Throws<DivideByZeroException>(() => calculator.Division(30, 0));
        }
    }
}
