using Calculator.Domain.CommonType;

namespace Calculator.Domain.Calculation
{
    public interface IExpressionCalculator
    {
        Result<int> Calculate(string input);
    }
}