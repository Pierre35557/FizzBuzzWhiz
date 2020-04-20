using NUnit.Framework;
using System.Linq;

namespace FizzBuzz
{
    [TestFixture]
    public class FizzBuzzTestCase
    {
        [TestCase(1, "1")]
        //[TestCase(2, "2")]
        [TestCase(4, "4")]
        public void GivenNaturalNumber_AndNumberIsNotDivisibleBy3or5_ShouldReturnNumber(int number, string expected)
        {
            //Act
            string actual = GetFizzBuzz(number);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        //New Boundary?
        //[TestCase(3, "Fizz")]
        [TestCase(6, "Fizz")]
        [TestCase(9, "Fizz")]
        public void GivenNaturalNumber_AndNumberIsDivisibleBy3_ShouldReturnFizz(int number, string expected)
        {
            //Act
            string actual = GetFizzBuzz(number);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        //New Boundary?
        //[TestCase(5, "Buzz")]
        [TestCase(10, "Buzz")]
        [TestCase(20, "Buzz")]
        public void GivenNaturalNumber_AndNumberIsDivisibleBy5_ShouldReturnBuzz(int number, string expected)
        {
            //Act
            string actual = GetFizzBuzz(number);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        //New Boundary?
        [TestCase(15, "FizzBuzz")]
        [TestCase(30, "FizzBuzz")]
        [TestCase(75, "FizzBuzz")]
        public void GivenNaturalNumber_AndNumberIsDivisibleBy3and5_ShouldReturnFizzBuzz(int number, string expected)
        {
            //Act
            string actual = GetFizzBuzz(number);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(2, "Whiz")]
        public void GivenPrimeNumber_AndNumberIsDivisibleBy1OrItself_ShouldReturnWhiz(int number, string expected)
        {
            //Act
            string actual = GetFizzBuzz(number);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        //New Boundary
        [TestCase(3, "FizzWhiz")]
        public void GivenPrimeNumber_And3IsDivisible_ShouldReturnFizzWizz(int number, string expected)
        {
            //Act
            string actual = GetFizzBuzz(number);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        //New Boundary
        [TestCase(5, "BuzzWhiz")]
        public void GivenPrimeNumber_And5IsDivisible_ShouldReturnBuzzWizz(int number, string expected)
        {
            //Act
            string actual = GetFizzBuzz(number);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        //New Boundary
        [TestCase(15, "FizzBuzzWizz")]
        public void GivenPrimeNumber_And15IsDivisible_ShouldReturnFizzBuzzWizz(int number, string expected)
        {
            //Act
            string actual = GetFizzBuzz(number);

            //Assert
            Assert.AreEqual(expected, actual);
        }


        private string GetFizzBuzz(int number)
        {
            var isPrime = Enumerable.Range(1, number).Where(c => number % c == 0).SequenceEqual(new[] { 1, number });

            if (number % 3 == 0 && number % 5 == 0)
                return isPrime ? "FizzBuzzWhiz" : "FizzBuzz";
            else if (number % 3 == 0)
                return isPrime ? "FizzWhiz" : "Fizz";
            else if (number % 5 == 0)
                return isPrime ? "BuzzWhiz" : "Buzz";
            else
                return isPrime ? "Whiz" : number.ToString();
        }
    }
}
