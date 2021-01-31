using Microsoft.Extensions.DependencyInjection;
using KinetoAPI.Common;
using KinetoAPI.Data;
using KinetoAPI.Services.Implementation;
using KinetoAPI.Services.Interfaces;

namespace KinetoAPI.Services
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