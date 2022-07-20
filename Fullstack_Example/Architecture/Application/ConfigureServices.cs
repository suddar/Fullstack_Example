using Fullstack_Example.Architecture.Application.GraphQL.Schemas.Courses;
using Fullstack_Example.Architecture.Application.GraphQL.Schemas.Topics;
using Fullstack_Example.Architecture.Application.MapperProfiles;
using System.Text.Json.Serialization;

namespace Fullstack_Example.Architecture.Application
{
    public static class ConfigureServices
    {
        public static IServiceCollection UseApplicationServices(this IServiceCollection services)
        {
            services.AddAutoMapper(typeof(MyProfile));

            //services.UseEntityServices<Teacher>();
            //services.UseEntityServices<Learner>();
            //services.UseEntityServices<Skill>();
            //services.UseEntityServices<Enrollment>();

            //services.UseEntityServices<Topic>();
            //services.UseEntityServices<Course>();

            services.AddScoped<IEntityService, EntityService>();

            services.AddControllers().AddJsonOptions(x =>
                x.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles);

            services
                .AddGraphQLServer()
                .InitializeOnStartup()
                .RegisterDbContext<AppDbContext>()
                .AddProjections()
                .AddFiltering()
                .AddSorting()

                // add queries
                .AddQueryType<TopicQuery>()
                .AddQueryType<CourseQuery>()

                // add mutations
                .AddMutationType<TopicMutation>()
                .AddMutationType<CourseMutation>()
                ;

            return services;
        }

        public static IServiceCollection UseEntityServices<TEntity>(this IServiceCollection services) where TEntity : BaseEntity
        {
            services.AddScoped<IEntityService, EntityService>();
            return services;
        }
    }
}
