using Calculator.WebApi.ActionHandlers;
using StructureMap;

namespace Calculator.WebApi.Configurations
{
    public class WebDependenciesConfig : Registry
    {
        public WebDependenciesConfig()
        {
            For<ICalculationActionHandler>().Use<CalculationActionHandler>();
        }
    }
}