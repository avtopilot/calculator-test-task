using Calculator.CQRS.Commands.Infrastructure;
using Calculator.Domain.CommonType;

namespace Calculator.CQRS.Commands
{
    public class CreateCalculatorHistoryCommand : ICommand
    {
        public string Input { get; set; }
        public Result<int> Result { get; set; }
    }
}