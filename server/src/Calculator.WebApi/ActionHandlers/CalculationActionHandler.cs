using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using Calculator.CQRS.Commands;
using Calculator.CQRS.Commands.Infrastructure;
using Calculator.CQRS.Queries;
using Calculator.CQRS.Queries.Infrastrucute;
using Calculator.Domain.Calculation;
using Calculator.WebApi.Dtos.Calculation;

namespace Calculator.WebApi.ActionHandlers
{
    public class CalculationActionHandler : ICalculationActionHandler
    {
        private readonly IExpressionCalculator _expressionCalculator;
        private readonly IQueryProcessor _queryProcessor;
        private readonly ICommandProcessor _commandProcessor;

        public CalculationActionHandler(IExpressionCalculator expressionCalculator, IQueryProcessor queryProcessor,
            ICommandProcessor commandProcessor)
        {
            _expressionCalculator = expressionCalculator;
            _queryProcessor = queryProcessor;
            _commandProcessor = commandProcessor;
        }

        public CalculationResultDto GetCalculationResult(string input)
        {
            var result = _expressionCalculator.Calculate(input);

            var command = new CreateCalculatorHistoryCommand
            {
                Input = input,
                Result = result
            };
            _commandProcessor.Process(command);
            
            return new CalculationResultDto
            {
                Input = input,
                ErrorText = result.ErrorText,
                Result = result.Value
            };
        }

        public CalculationHistoryDto GetHistory()
        {
            var query = new GetCalculatorHistoryContext();
            var history = _queryProcessor.For<IEnumerable<CalculatorHistory>>().Process(query);

            return new CalculationHistoryDto {History = history.Select(Mapper.Map<CalculationResultDto>)};
        }
    }
}