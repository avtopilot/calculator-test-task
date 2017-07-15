using Calculator.DataAccess.Repositories.Calculation;
using StructureMap;

namespace Calculator.DataAccess
{
    public class DataAccessConfig : Registry
    {
        public DataAccessConfig()
        {
            For<ICalculationHistoryRepository>().Use<CalculationHistoryRepository>();
        }
    }
}