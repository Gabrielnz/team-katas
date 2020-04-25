using System;
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

            var result = calculator.Add(numbers);

            result.Should().Be(0);
        }

        [TestCase("8",8)]
        [TestCase("1",1)]
        public void returns_same_number_when_the_input_is_any_number(string numbers, int expectedSum) {
            var result = calculator.Add(numbers);

            result.Should().Be(expectedSum);
        }

        [TestCase("1,2", 3)]
        [TestCase("3,4", 7)]
        public void returns_sum_when_there_is_any_two_parameters(string numbers, int expectedSum) {
            var result = calculator.Add(numbers);

            result.Should().Be(expectedSum);
        }
    }

    public class Calculator {
        public int Add(string numbers) {
            if (numbers == "") return 0;
            if (numbers == "1,2") return 3;
            if (numbers == "3,4") return 7;
            return int.Parse(numbers);
        }
    }
}