using Calculator.Domain.CommonType;

namespace Calculator.Domain.Calculation
{
    public class CalculatorHistory
    {
        public string Input { get; set; }
        public Result<int> Result { get; set; }
    }
}