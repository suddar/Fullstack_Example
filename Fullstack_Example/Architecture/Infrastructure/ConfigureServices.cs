using Fullstack_Example.Architecture.Domain.Entities.Authentication;
using Fullstack_Example.Architecture.Domain.Entities.Authorization;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Fullstack_Example.Architecture.Infrastructure
{
    public static class ConfigureServices
    {
        public static IServiceCollection UseInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
        {
            var connectionString = configuration.GetConnectionString("DefaultConnection");

            services.AddDbContext<AppDbContext>(options => options.UseSqlServer(connectionString));

            //services.AddDatabaseDeveloperPageExceptionFilter();

            /*            services
                            .AddIdentity<AppUser>(options =>
                            {
                                // options are set here
                            })
                            .AddRoles<UserRole>()
                            .AddEntityFrameworkStores<AppDbContext>();*/

            return services;
        }
    }
}
