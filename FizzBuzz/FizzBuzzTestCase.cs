using NUnit.Framework;

namespace FizzBuzz
{
    [TestFixture]
    public class FizzBuzzTestCase
    {
        [Test]
        public void GivenNaturalNumber_And1IsNotDivisible_ShouldReturn1()
        {
            //Arrange
            int number = 1;

            //Act
            string actual = GetFizzBuzz(number);
            string expected = "1";

            //Assert
            Assert.AreEqual(expected, actual);
        }

        //New Boundary?
        [Test]
        public void GivenNaturalNumber_And3IsDivisible_ShouldReturnFizz()
        {
            //Arrange
            int number = 3;

            //Act
            string actual = GetFizzBuzz(number);
            string expected = "Fizz";

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void GivenNaturalNumber_And6IsDivisible_ShouldReturnFizz()
        {
            //Arrange
            int number = 6;

            //Act
            string actual = GetFizzBuzz(number);
            string expected = "Fizz";

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void GivenNaturalNumber_And9IsDivisible_ShouldReturnFizz()
        {
            //Arrange
            int number = 9;

            //Act
            string actual = GetFizzBuzz(number);
            string expected = "Fizz";

            //Assert
            Assert.AreEqual(expected, actual);
        }

        //New Boundary?
        [Test]
        public void GivenNaturalNumber_And5IsDivisible_ShouldReturnBuzz()
        {
            //Arrange
            int number = 5;

            //Act
            string actual = GetFizzBuzz(number);
            string expected = "Buzz";

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void GivenNaturalNumber_And10IsDivisible_ShouldReturnBuzz()
        {
            //Arrange
            int number = 10;

            //Act
            string actual = GetFizzBuzz(number);
            string expected = "Buzz";

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void GivenNaturalNumber_And20IsDivisible_ShouldReturnBuzz()
        {
            //Arrange
            int number = 20;

            //Act
            string actual = GetFizzBuzz(number);
            string expected = "Buzz";

            //Assert
            Assert.AreEqual(expected, actual);
        }

        //New Boundary?
        [Test]
        public void GivenNaturalNumber_And15IsDivisible_ShouldReturnFizzBuzz()
        {
            //Arrange
            int number = 15;

            //Act
            string actual = GetFizzBuzz(number);
            string expected = "FizzBuzz";

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void GivenNaturalNumber_And30IsDivisible_ShouldReturnFizzBuzz()
        {
            //Arrange
            int number = 30;

            //Act
            string actual = GetFizzBuzz(number);
            string expected = "FizzBuzz";

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void GivenNaturalNumber_And75IsDivisible_ShouldReturnFizzBuzz()
        {
            //Arrange
            int number = 75;

            //Act
            string actual = GetFizzBuzz(number);
            string expected = "FizzBuzz";

            //Assert
            Assert.AreEqual(expected, actual);
        }

        //New Boundary
        [Test]
        public void GivenPrimeNumber_And2IsDivisible_ShouldReturnWizz()
        {
            //Arrange
            int number = 2;

            //Act
            string actual = GetFizzBuzz(number, true);
            string expected = "Whiz";

            //Assert
            Assert.AreEqual(expected, actual);
        }

        //New Boundary
        [Test]
        public void GivenPrimeNumber_And3IsDivisible_ShouldReturnFizzWizz()
        {
            //Arrange
            int number = 3;

            //Act
            string actual = GetFizzBuzz(number, true);
            string expected = "FizzWhiz";

            //Assert
            Assert.AreEqual(expected, actual);
        }

        //New Boundary
        [Test]
        public void GivenPrimeNumber_And5IsDivisible_ShouldReturnBuzzWizz()
        {
            //Arrange
            int number = 5;

            //Act
            string actual = GetFizzBuzz(number, true);
            string expected = "BuzzWhiz";

            //Assert
            Assert.AreEqual(expected, actual);
        }

        //New Boundary
        [Test]
        public void GivenPrimeNumber_And15IsDivisible_ShouldReturnFizzBuzzWizz()
        {
            //Arrange
            int number = 15;

            //Act
            string actual = GetFizzBuzz(number, true);
            string expected = "FizzBuzzWhiz";

            //Assert
            Assert.AreEqual(expected, actual);
        }


        private string GetFizzBuzz(int number, bool prime = false)
        {
            if (prime)
            {
                if (number % 3 == 0 && number % 5 == 0)
                    return "FizzBuzzWhiz";
                else if (number % 3 == 0)
                    return "FizzWhiz";
                else if (number % 5 == 0)
                    return "BuzzWhiz";
                else
                    return "Whiz";
            }
            else
            {
                if (number % 3 == 0 && number % 5 == 0)
                    return "FizzBuzz";
                else if (number % 3 == 0)
                    return "Fizz";
                else if (number % 5 == 0)
                    return "Buzz";
            }

            return number.ToString();
        }
    }
}
