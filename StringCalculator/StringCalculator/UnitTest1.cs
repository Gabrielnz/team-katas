using FluentAssertions;
using NUnit.Framework;

namespace StringCalculator {
    public class Tests {
        private Calculator calculator;

        [SetUp]
        public void Setup() {
            calculator = new Calculator();
        }

        [Test]
        public void ReturnsZeroWhenThereAreNoNumbers() {
            const string numbers = "";

            var result = calculator.Sum(numbers);

            result.Should().Be(0);
        }
    }

    class Calculator {
        public int Sum(string numbers) {
            return 0;
        }
    }
}