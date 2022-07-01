using Fullstack_Example.Architecture.Infrastructure;
using MediatR;
using System.Reflection;

namespace Fullstack_Example.Configurations
{
    public static class StartupConfig
    {
        public static IServiceCollection UseCommonServices(this IServiceCollection services, IConfiguration configuration)
        {
            // Add services to the container.
            services.AddControllers();
            services.AddEndpointsApiExplorer();
            services.AddSwaggerGen();
            services.AddCors();

            services.AddMediatR(Assembly.GetExecutingAssembly());

            return services;
        }

        public static void UseCommonPiplines(this WebApplication app)
        {
            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();

            app.MapControllers();

            // global cors policy
            app.UseCors(x => x
                .AllowAnyMethod()
                .AllowAnyHeader()
                .SetIsOriginAllowed(origin => true) // allow any origin
                .AllowCredentials()); // allow credentials
        }
    }
}
