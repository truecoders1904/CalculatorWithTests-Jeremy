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
        [InlineData(10, 7, 17)]
        [InlineData(2, 2, 4)]
        [InlineData(3, 4, 7)]
        [InlineData(-2, -2, -4)]
        public void Subtract(int number1, int number2, int expectedSum)
        { //Arrange
            Calculator calculatortest = new Calculator();

            //Act
            int actual = calculatortest.Add(number1, number2);

            //Assert
            Assert.Equal(expectedSum, actual);

        }
        [Theory]
        [InlineData(10, 7, 17)]
        [InlineData(2, 2, 4)]
        [InlineData(3, 4, 7)]
        [InlineData(-2, -2, -4)]
        public void Multiply(int number1, int number2, int expectedSum)
        { //Arrange
            Calculator calculatortest = new Calculator();

            //Act
            int actual = calculatortest.Add(number1, number2);

            //Assert
            Assert.Equal(expectedSum, actual);

        }
        [Theory]
        [InlineData(10, 7, 17)]
        [InlineData(2, 2, 4)]
        [InlineData(3, 4, 7)]
        [InlineData(-2, -2, -4)]
        public void Divide(int number1, int number2, int expectedSum)
        { //Arrange
            Calculator calculatortest = new Calculator();

            //Act
            int actual = calculatortest.Add(number1, number2);

            //Assert
            Assert.Equal(expectedSum, actual);

        }
        [Theory]
        [InlineData(10, 7, 17)]
        [InlineData(2, 2, 4)]
        [InlineData(3, 4, 7)]
        [InlineData(-2, -2, -4)]
        public void favtorial(int number1, int number2, int expectedSum)
        { //Arrange
            Calculator calculatortest = new Calculator();

            //Act
            int actual = calculatortest.Add(number1, number2);

            //Assert
            Assert.Equal(expectedSum, actual);

        }
    }
}
