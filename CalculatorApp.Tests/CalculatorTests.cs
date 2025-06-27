
using NUnit.Framework;
using System;

namespace CalculatorApp.Tests
{
    [TestFixture]
    public class CalculatorTests
    {
        private Calculator _calc;

        [SetUp]
        public void Init() => _calc = new Calculator();

        [TearDown]
        public void Cleanup() => _calc = null;

        [Test, Category("Arithmetic")]
        public void Test_Addition() => Assert.AreEqual(8, _calc.Add(5, 3));

        [Test, Category("Arithmetic")]
        public void Test_Subtraction() => Assert.AreEqual(6, _calc.Subtract(10, 4));

        [Test, Category("Arithmetic")]
        public void Test_Multiplication() => Assert.AreEqual(42, _calc.Multiply(6, 7));

        [Test, Category("Arithmetic")]
        public void Test_Division() => Assert.AreEqual(3, _calc.Divide(12, 4));

        [Test, Category("Exception")]
        public void Test_DivideByZero_Throws() =>
            Assert.Throws<DivideByZeroException>(() => _calc.Divide(10, 0));
    }
}
