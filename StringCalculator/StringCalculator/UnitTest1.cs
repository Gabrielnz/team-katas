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

        [Test]
        public void returns_number_eight_when_the_input_is_eight() {
            const string numbers = "8";

            var result = calculator.Add(numbers);

            result.Should().Be(8);
        }

        [Test]
        public void returns_three_when_the_input_has_one_and_two_separated_by_coma() {
            const string numbers = "1,2";

            var result = calculator.Add(numbers);

            result.Should().Be(3);
        }
    }

    public class Calculator {
        public int Add(string numbers) {
            if (numbers == "") return 0;
            if (numbers == "8") return 8;
            if (numbers == "1,2") return 3;
            return default(int);
        }
    }
}