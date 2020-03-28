using Microsoft.Extensions.DependencyInjection;
using WebApplicationCommon;
using WebApplicationData;
using WebApplicationData.Entities;
using WebApplicationServices.Implementation;
using WebApplicationServices.Interfaces;

namespace WebApplicationServices
{
    public static class ServicesConfiguration
    {
        public static void RegisterDependencies(IServiceCollection services)
        {
            CommonConfiguration.RegisterDependencies(services);
            DataConfiguration.RegisterDependencies(services);

            services.AddTransient<IUserService, UserService>();
            services.AddTransient<IPatientService, PatientService>();
            services.AddTransient<IAppointmentService, AppointmentService>();
            services.AddTransient<ITreatmentService, TreatmentService>();
        }
    }
}