using Aurastha.Api.Business;
using Aurastha.Api.Business.Interfaces;
using Aurastha.Api.Models.Profiles.EmployeeDetails;
using Aurastha.Api.Repository;
using Aurastha.Api.Repository.Interfaces;

namespace Aurastha.API.Extensions
{
    public static class ServiceScopeExtension
    {
        public static IServiceCollection AddServicesScope(this IServiceCollection services,
                                                            IWebHostEnvironment HostingEnvironment,
                                                            IConfiguration configuration) 
        {
            services.AddSingleton(HostingEnvironment);
            services.AddSingleton(configuration);
            //services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
            services.AddAutoMapper(typeof(EmployeeProfile));
            services.AddHttpContextAccessor();

            services.AddTransient<IEmployeeService, EmployeeService>();
            services.AddScoped<IEmployeeRepository, EmployeeRepository>();

            return services;
        }
    }
}
