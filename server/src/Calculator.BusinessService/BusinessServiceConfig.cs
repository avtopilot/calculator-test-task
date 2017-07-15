using Calculator.BusinessService.Calculation;
using Calculator.Domain.Calculation;
using StructureMap;

namespace Calculator.BusinessService
{
    public class BusinessServiceConfig : Registry
    {
        public BusinessServiceConfig()
        {
            For<IExpressionCalculator>().Use<ExpressionCalculator>();
        }
    }
}