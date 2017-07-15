using Calculator.CQRS.Commands;
using Calculator.CQRS.Commands.Handlers;
using Calculator.CQRS.Commands.Infrastructure;
using StructureMap;

namespace Calculator.CQRS
{
    public class CommandsInstaller : Registry
    {
        public CommandsInstaller()
        {
            For<ICommandHandler<CreateCalculatorHistoryCommand>>().Use<CreateCalculatorHistoryCommandHandler>();
        }
    }
}