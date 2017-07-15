using System;
using Calculator.CQRS.Commands.Infrastructure;
using Calculator.CQRS.Queries.Infrastrucute;
using StructureMap;

namespace Calculator.CQRS
{
    public class CqrsInstaller : Registry
    {
        public CqrsInstaller(Container container)
        {
            var resolveCommandProcessorFunc =
                new Func<Type, object>(t => container.GetInstance(typeof(ICommandHandler<>).MakeGenericType(t)));

            // i know this will be an issue for performance, but for the current task it's ok
            For<ICommandProcessor>()
                .Use<CommandProcessor>()
                .Ctor<Func<Type, object>>("func")
                .Is(resolveCommandProcessorFunc);


            // Query
            var resolveQueryProcessorFunc =
                new Func<Type, Type, object>(
                    (t1, t2) => container.GetInstance(typeof(IQuery<,>).MakeGenericType(t1, t2)));

            For<IQueryProcessor>().Use<QueryProcessor>().Ctor<Func<Type, Type, object>>("func")
                .Is(resolveQueryProcessorFunc);
        }
    }
}