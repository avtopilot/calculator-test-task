using System;
using Calculator.BusinessService;
using Calculator.CQRS;
using Calculator.DataAccess;
using Microsoft.Extensions.DependencyInjection;
using StructureMap;

namespace Calculator.WebApi.Configurations
{
    public class ApiDependenciesConfig
    {
        public static IServiceProvider Create(IServiceCollection services)
        {
            var container = new Container();

            container.Configure(
                _ =>
                {
                    _.AddRegistry(new CqrsInstaller(container));
                    _.AddRegistry(new QueriesInstaller());
                    _.AddRegistry(new CommandsInstaller());
                    _.AddRegistry(new DataAccessConfig());
                    _.AddRegistry(new WebDependenciesConfig());
                    _.AddRegistry(new BusinessServiceConfig());
                });

            container.Populate(services);

            return container.GetInstance<IServiceProvider>();
        }
    }
}