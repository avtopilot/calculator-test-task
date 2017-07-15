using System;
using System.Collections.Generic;
using Calculator.CQRS.Queries.Infrastrucute;
using Calculator.Domain.Calculation;

namespace Calculator.CQRS.Queries.Handlers
{
    public class GetCalculatorHistoryQuery : IQuery<GetCalculatorHistoryContext, IEnumerable<CalculatorHistory>>
    {
        public IEnumerable<CalculatorHistory> Execute(GetCalculatorHistoryContext queryContext)
        {
            throw new NotImplementedException();
        }
    }
}