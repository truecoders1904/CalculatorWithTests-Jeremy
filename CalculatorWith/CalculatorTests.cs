using System;
using Xunit;


namespace CalculatorWithTests.Tests
{
    public class CalculatorTests
    {
        [Theory]
        [InlineData(10, 7, 17)]
        [InlineData(2, 2, 4)]
        [InlineData(3, 4, 7)]
        [InlineData(-2, -2, -4)]
        public void Add(int number1, int number2, int expectedSum)
        { //Arrange
            Calculator calculatortest = new Calculator();

            //Act
            int actual = calculatortest.Add(number1, number2);

            //Assert
            Assert.Equal(expectedSum, actual);

        }
        [Theory]
        [InlineData(10, 7, 10)]
        [InlineData(2, 2, 0)]
        [InlineData(3, 4, -1)]
        [InlineData(20, -2, 18)]
        public void Subtract(double minuend, double subtrahend, double expectedDifference)
        { //Arrange
            Calculator calculatortest = new Calculator();

            //Act
            double actual = calculatortest.Subtract(minuend , subtrahend);

            //Assert
            Assert.Equal(expectedDifference, actual);

        }
        [Theory]
        [InlineData(10, 7, 70)]
        [InlineData(2, 2, 4)]
        [InlineData(3, 4, 12)]
        [InlineData(4, 22, 8)]
        public void Multiply(long number1, long number2, long expectedProduct)
        { //Arrange
            Calculator calculatortest = new Calculator();

            //Act
            long actual = calculatortest.Multiply(number1, number2);

            //Assert
            Assert.Equal(expectedProduct, actual);

        }
        [Theory]
        [InlineData(10, 7, 17)]
        [InlineData(2, 2, 1)]
        [InlineData(10, 5, 2)]
        [InlineData(20, 4, 5)]
        public void Divide(double number1, double number2, double expectedquotient)
        { //Arrange
            Calculator calculatortest = new Calculator();

            //Act
            double actual = calculatortest.Divide(number1, number2);

            //Assert
            Assert.Equal(expectedquotient, actual);

        }
        [Theory]
        [InlineData(2,2)]
        [InlineData(4,24)]
        [InlineData(3,6)]
        [InlineData(5,120)]
        public void factorial(int number1,int expectedfact)
        { //Arrange
            Calculator calculatortest = new Calculator();

            //Act
            int actual = calculatortest.factorial(number1);

            //Assert
            Assert.Equal(expectedfact, actual);

        }
    }
}
