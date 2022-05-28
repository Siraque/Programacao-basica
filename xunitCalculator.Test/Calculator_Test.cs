using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using xunitCalculartor;
using Xunit;

namespace xunitCalculator.Test
{
    public class Calculator_Test
    {
        [Fact]
        public void Add_CalculatorShouldAddTwoNumbers()
        {
            //Arrange
            double number1 = 5.5;
            double number2 = 4.5;
            double expectedResult = 10;

            //Act
            double actualResult = Calculator.Addition(number1, number2);

            //Assert
            Assert.Equal(expectedResult, actualResult);

        }

        [Fact]
        public void Sub_CalculatorShouldSubTwoNumbers()
        {
            //Arrange
            double number1 = 4.2;
            double number2 = 5.2;
            double expectResult = -1;

            //Act
            double actualResult = Calculator.subtraction(number1, number2);

            //Assert
            Assert.Equal(expectResult, actualResult);
        }

        [Theory]
        [InlineData(2, 3, 6)]
        [InlineData(5.25, 98.4, 516.6)]
        [InlineData(-5, 5, -25)]
        public void Mult_CalculatorShouldMultTwoNumbers(double a, double b, double expectedResult)
        {
            //Arrange

            //Act
            double actualResult = Calculator.Multiplication(a, b);

            //Assert
            Assert.Equal(expectedResult, actualResult);
        }


        [Theory]
        [InlineData(10, 5, 2)]
        [InlineData(0, 2, 0)]
        [InlineData(-20, -10, 2)]
        [InlineData(-5, 5, -1)]
        public void Div_CalculatorShouldDivTwoNumbers(double a, double b, double expectedResult)
        {
            //Arrange

            //Act
            double actualResult = Calculator.Division(a, b);

            //Assert
            Assert.Equal(expectedResult, actualResult);

        }

        [Theory]
        [InlineData(1, 0, "Divide by Zero Error!")]
        [InlineData(0, 0, "Divide by Zero Error!")]
        public void Div_ZeroException(double a, double b, string expectedErrorMessage)
        {
            //Arrange

            //Act
            var ex = Assert.Throws<DivideByZeroException>(() => Calculator.Division(a, b));

            //Assert
            Assert.Equal(expectedErrorMessage, ex.Message);
        }


    }
}
