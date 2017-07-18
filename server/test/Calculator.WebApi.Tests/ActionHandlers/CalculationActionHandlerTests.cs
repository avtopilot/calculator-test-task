using System.Collections.Generic;
using Calculator.CQRS.Commands;
using Calculator.CQRS.Commands.Infrastructure;
using Calculator.CQRS.Queries;
using Calculator.CQRS.Queries.Infrastrucute;
using Calculator.Domain.Calculation;
using Calculator.Domain.CommonType;
using Calculator.WebApi.ActionHandlers;
using NSubstitute;
using Xunit;

namespace Calculator.WebApi.Tests.ActionHandlers
{
    public class CalculationActionHandlerTests
    {
        [Fact]
        public void GetCalculationResult_Should_Call_Calculation_Service()
        {
            // Arrange
            var sut = new CalculationActionHandlerSut();
            sut.ExpressionCalculator.Calculate(Arg.Any<string>()).ReturnsForAnyArgs(new Result<int>());

            // Act
            sut.GetCalculationResult("test");

            // Assert
            sut.ExpressionCalculator.Received().Calculate("test");
        }

        [Fact]
        public void GetCalculationResult_Should_Save_The_Result()
        {
            // Arrange
            var sut = new CalculationActionHandlerSut();
            sut.ExpressionCalculator.Calculate(Arg.Any<string>()).ReturnsForAnyArgs(new Result<int>());
            sut.CommandProcessor.Process(Arg.Any<CreateCalculatorHistoryCommand>());

            // Act
            sut.GetCalculationResult("test");

            // Assert
            sut.CommandProcessor.Received().Process(Arg.Any<CreateCalculatorHistoryCommand>());
        }

        [Fact]
        public void GetHistory_Should_Process_Query()
        {
            // Arrange
            var sut = new CalculationActionHandlerSut();
            sut.QueryProcessor.For<IEnumerable<CalculatorHistory>>().Process(Arg.Any<GetCalculatorHistoryContext>())
                .ReturnsForAnyArgs(new List<CalculatorHistory>());

            // Act
            sut.GetHistory();

            // Assert
            sut.QueryProcessor.Received().For<IEnumerable<CalculatorHistory>>().Process(Arg.Any<GetCalculatorHistoryContext>());
        }
    }

    public class CalculationActionHandlerSut : CalculationActionHandler
    {
        public IExpressionCalculator ExpressionCalculator { get; }
        public IQueryProcessor QueryProcessor { get; }
        public ICommandProcessor CommandProcessor { get; }
        
        public CalculationActionHandlerSut(IExpressionCalculator expressionCalculator, IQueryProcessor queryProcessor,
            ICommandProcessor commandProcessor) : base(expressionCalculator, queryProcessor, commandProcessor)
        {
            ExpressionCalculator = expressionCalculator;
            QueryProcessor = queryProcessor;
            CommandProcessor = commandProcessor;
        }
        
        public CalculationActionHandlerSut() : this(
            Substitute.For<IExpressionCalculator>(),
            Substitute.For<IQueryProcessor>(),
            Substitute.For<ICommandProcessor>()
        )
        {}
    }
}