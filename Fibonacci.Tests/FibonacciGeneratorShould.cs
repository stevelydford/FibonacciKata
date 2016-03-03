using System;
using NUnit.Framework;

namespace Fibonacci.Tests
{
    [TestFixture]
    public class FibonacciGeneratorShould
    {
        private FibonacciGenerator _fibonacciGenerator;

        [SetUp]
        public void SetUp()
        {
            _fibonacciGenerator = new FibonacciGenerator();
        }

        [TestCase(0)]
        [TestCase(31)]
        public void NotAcceptInvalidValues(int invalidSequenceNumber)
        {
            Assert.That(() => _fibonacciGenerator.Generate(invalidSequenceNumber), Throws.Exception.TypeOf<ArgumentOutOfRangeException>());
        }

        [TestCase(1, new[] { 0 })]
        [TestCase(2, new[] { 0, 1 })]
        [TestCase(3, new[] { 0, 1, 1 })]
        [TestCase(10, new[] { 0, 1, 1, 2, 3, 5, 8, 13, 21, 34 })]
        public void ReturnsTheFibonacciSequence(int sequenceNumber, int[] expectedFibonacciSequence)
        {
            var result = _fibonacciGenerator.Generate(sequenceNumber);

            Assert.That(result, Is.EqualTo(expectedFibonacciSequence));
        }
    }
}
