namespace Calculator.CQRS.Commands.Infrastructure
{
    public interface ICommandProcessor
    {
        void Process<TCommand>(TCommand command) where TCommand : ICommand;
    }
}