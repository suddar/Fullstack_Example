using Fullstack_Example.Architecture.Application.MapperProfiles;
using Fullstack_Example.Architecture.Application.Services;
using System.Reflection;

namespace Fullstack_Example.Architecture.Application
{
    public static class ConfigureServices
    {
        public static IServiceCollection UseApplicationServices(this IServiceCollection services)
        {
            services.AddMediatR(Assembly.GetExecutingAssembly());
            services.AddAutoMapper(typeof(MyProfile));

            services.AddTransient<ICommandService, CommandService>();
            return services;
        }
    }
}
