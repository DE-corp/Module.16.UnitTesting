using NUnit.Framework;

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
    }
}
