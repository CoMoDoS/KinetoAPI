using Microsoft.Extensions.DependencyInjection;
using WebApplicationCommon;

namespace WebApplicationData
{
    public static class DataConfiguration
    {
        public static void RegisterDependencies(IServiceCollection services)
        {
            CommonConfiguration.RegisterDependencies(services);

            services.AddTransient<IUnitOfWork, UnitOfWork>();
            
        }
    }
}