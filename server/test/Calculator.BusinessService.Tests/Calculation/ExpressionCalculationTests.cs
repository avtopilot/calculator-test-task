using Calculator.BusinessService.Calculation;
using Xunit;

namespace Calculator.BusinessService.Tests.Calculation
{
    public class ExpressionCalculationTests
    {
        [Theory]
        [InlineData("2+3*4+5", 19)]
        [InlineData("2*3*4*5", 120)]
        [InlineData("1+1", 2)]
        [InlineData("(2+3)*(4+5)", 45)]
        [InlineData("1+(2+3)*(4+5)", 46)]
        public void ValidExpression_Should_Return_IntResult(string input, int expectedResult)
        {
            var calculator = new ExpressionCalculator();

            var result = calculator.Calculate(input);

            Assert.Equal(expectedResult, result.Value);
        }

        [Theory]
        [InlineData("2+3*4+", true, "Error")]
        [InlineData("((2+3)*(4+5))", true, "Sorry, this is too complex")]
        [InlineData("((2+3)", true, "Error")]
        [InlineData("(2+3)*(", true, "Error")]
        public void InvalidExpression_Should_Return_AnErrorMessage(string input, bool expectedResult, string errorMessage)
        {
            var calculator = new ExpressionCalculator();

            var result = calculator.Calculate(input);

            Assert.Equal(expectedResult, result.IsError);
            Assert.Equal(errorMessage, result.ErrorText);
        }
    }
}