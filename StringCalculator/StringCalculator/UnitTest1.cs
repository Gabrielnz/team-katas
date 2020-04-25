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
        public void returns_zero_when_there_are_no_numbers() {
            const string numbers = "";

            var result = Calculator.Sum(numbers);

            result.Should().Be(0);
        }
    }

    public class Calculator {
        public static int Sum(string numbers) {
            return 0;
        }
    }
}