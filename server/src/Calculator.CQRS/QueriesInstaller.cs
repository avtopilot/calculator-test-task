using System.Collections.Generic;
using Calculator.CQRS.Queries;
using Calculator.CQRS.Queries.Handlers;
using Calculator.CQRS.Queries.Infrastrucute;
using Calculator.Domain.Calculation;
using StructureMap;

namespace Calculator.CQRS
{
    public class QueriesInstaller : Registry
    {
        public QueriesInstaller()
        {
            For<IQuery<GetCalculatorHistoryContext, IEnumerable<CalculatorHistory>>>().Use<GetCalculatorHistoryQuery>();
        }
    }
}