using System;
using System.Collections.Generic;
using System.Linq;
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
        [TestCase("5,6", 11)]
        public void returns_sum_when_there_is_any_two_parameters(string numbers, int expectedSum) {
            var result = calculator.Add(numbers);

            result.Should().Be(expectedSum);
        }
    }

    public class Calculator {
        public int Add(string valuesToSumSeparatedWithCommas) {
            if (HasNoValuesToSum(valuesToSumSeparatedWithCommas)) return 0;
            var numbersToSum = ConvertValuesToNumbers(GetValuesToSumFrom(valuesToSumSeparatedWithCommas));
            if (HasOneNumber(numbersToSum)) return numbersToSum[0];
            return numbersToSum[0] + numbersToSum[1];
        }

        private int[] ConvertValuesToNumbers(string[] valuesToSum) {
            return valuesToSum.Select(valueToSum => int.Parse(valueToSum)).ToArray();
        }

        private static bool HasNoValuesToSum(string numbersToSumSeparatedWithCommas) {
            return numbersToSumSeparatedWithCommas == "";
        }

        private static bool HasOneNumber(int[] numbersToSum) {
            return numbersToSum.Length == 1;
        }

        private static string[] GetValuesToSumFrom(string numbersToSumSeparatedWithCommas) {
            return numbersToSumSeparatedWithCommas.Split(',');
        }
    }
}