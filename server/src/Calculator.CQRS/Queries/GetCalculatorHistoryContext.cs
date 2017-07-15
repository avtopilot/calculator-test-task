using System.Collections.Generic;
using Calculator.CQRS.Queries.Infrastrucute;
using Calculator.Domain.Calculation;

namespace Calculator.CQRS.Queries
{
    public class GetCalculatorHistoryContext : IQueryContext<IEnumerable<CalculatorHistory>>
    {
    }
}