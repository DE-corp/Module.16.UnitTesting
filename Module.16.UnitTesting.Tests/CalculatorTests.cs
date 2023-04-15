using System;
using Xunit;

namespace Module._16.UnitTesting.Tests
{
    public class CalculatorTests
    {
        [Fact]
        public void Subtraction_MustReturnCorrectValue()
        {
            Calculator calculator = new Calculator();
            Assert.True(calculator.Subtraction(300, 10) == 290);
        }

        [Fact]
        public void Division_MustReturnCorrectValue()
        {
            Calculator calculator = new Calculator();
            Assert.True(calculator.Division(10, 5) == 2);
        }

        [Fact]
        public void Division_MustThrowException()
        {
            Calculator calculator = new Calculator();
            Assert.Throws<DivideByZeroException>(() => calculator.Division(30, 0));
        }
    }
}
