using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using Calculator.CQRS.Queries.Infrastrucute;
using Calculator.DataAccess.Repositories.Calculation;
using Calculator.Domain.Calculation;

namespace Calculator.CQRS.Queries.Handlers
{
    public class GetCalculatorHistoryQuery : IQuery<GetCalculatorHistoryContext, IEnumerable<CalculatorHistory>>
    {
        private readonly ICalculationHistoryRepository _calculationHistoryRepository;

        public GetCalculatorHistoryQuery(ICalculationHistoryRepository calculationHistoryRepository)
        {
            _calculationHistoryRepository = calculationHistoryRepository;
        }

        public IEnumerable<CalculatorHistory> Execute(GetCalculatorHistoryContext queryContext)
        {
            var results = _calculationHistoryRepository.GetAll();

            return results.Select(Mapper.Map<CalculatorHistory>);
        }
    }
}