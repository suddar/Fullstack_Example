using Fullstack_Example.Application.Services;

namespace Fullstack_Example.Architecture.Application
{
    public static class ConfigureServices
    {
        public static IServiceCollection UseApplicationServices(this IServiceCollection services)
        {
            services.UseEntityServices<Teacher>();
            services.UseEntityServices<Learner>();
            services.UseEntityServices<Skill>();
            services.UseEntityServices<Enrollment>();
            return services;
        }

        public static IServiceCollection UseEntityServices<TEntity>(this IServiceCollection services) where TEntity : BaseEntity
        {
            services.AddScoped<IEntityService<TEntity>, EntityService<TEntity>>();
            return services;
        }
    }
}
