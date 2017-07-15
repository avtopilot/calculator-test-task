using Calculator.CQRS.Commands.Infrastructure;
using Calculator.DataAccess.Entities.Calculation;
using Calculator.DataAccess.Repositories.Calculation;

namespace Calculator.CQRS.Commands.Handlers
{
    public class CreateCalculatorHistoryCommandHandler : ICommandHandler<CreateCalculatorHistoryCommand>
    {
        private readonly CalculationHistoryRepository _calculationHistoryRepository;

        public CreateCalculatorHistoryCommandHandler(CalculationHistoryRepository calculationHistoryRepository)
        {
            _calculationHistoryRepository = calculationHistoryRepository;
        }

        public void Handle(CreateCalculatorHistoryCommand command)
        {
            var history = new CalculationHistoryEntity(command.Input, command.Result.Value, command.Result.ErrorText);
            _calculationHistoryRepository.Insert(history);
        }
    }
}