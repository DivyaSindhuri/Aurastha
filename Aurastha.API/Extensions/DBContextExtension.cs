using Aurastha.Api.Repository.DatabaseContext;
using Microsoft.EntityFrameworkCore;

namespace Aurastha.API.Extensions
{
    public static class DBContextExtension
    {
        public static IServiceCollection AddDBContextConfiguration(this IServiceCollection services
                                                                   , IConfiguration configuration) 
        {
            services.AddDbContext<DataContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("Database")));
            return services;
        }
    }
}
