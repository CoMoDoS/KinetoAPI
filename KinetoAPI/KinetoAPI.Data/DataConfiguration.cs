using Microsoft.Extensions.DependencyInjection;
using KinetoAPI.Common;

namespace KinetoAPI.Data
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