using Fullstack_Example.Architecture.Infrastructure;
using MediatR;
using Microsoft.Extensions.FileProviders;
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

            app.UseStaticFiles();
            /*            app.UseStaticFiles(new StaticFileOptions
                        {
                            FileProvider = new PhysicalFileProvider(
                                Path.Combine(app.Environment.ContentRootPath, "ClientApp/sveltekit/build")),
                            RequestPath = ""
                        });*/

            app.UseAuthorization();

            app.MapControllers();

            //app.MapGraphQL();

            // global cors policy
            app.UseCors(x => x
                .AllowAnyMethod()
                .AllowAnyHeader()
                .SetIsOriginAllowed(origin => true) // allow any origin
                .AllowCredentials()); // allow credentials
        }
    }
}
