using NUnit.Framework;

namespace Module._16.UnitTesting.Tests
{
    [TestFixture]
    public class CalculatorTests
    {
        [Test]
        public void AdditionalMustReturnCorrectValue()
        {
            var calculator = new Calculator();
            int result = calculator.Additional(50, 13);
            Assert.AreEqual(63, result);
        }

        [Test]
        public void SubtractionMustReturnCorrectValue()
        {
            var calculator = new Calculator();
            int result = calculator.Subtraction(62, 10);
            Assert.AreEqual(52, result);
        }

        [Test]
        public void MultiplicationMustReturnCorrectValue()
        {
            var calculator = new Calculator();
            int result = calculator.Multiplication(3, 2);
            Assert.AreEqual(6, result);
        }

        [Test]
        public void DivisionMustReturnCorrectValue()
        {
            var calculator = new Calculator();
            int result = calculator.Division(150, 10);
            Assert.AreEqual(15, result);
        }
    }
}
