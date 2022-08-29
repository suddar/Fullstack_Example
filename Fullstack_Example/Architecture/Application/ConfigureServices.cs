using Fullstack_Example.Architecture.Application.GraphQL.CoutnryMutateResolver;
using Fullstack_Example.Architecture.Application.GraphQL.MutationResolver;
using Fullstack_Example.Architecture.Application.GraphQL.QueryResolvers;
using Fullstack_Example.Architecture.Application.GraphQL.QueryTypes;
using Fullstack_Example.Architecture.Application.GraphQL.Schemas.Topics;
using Fullstack_Example.Architecture.Application.MapperProfiles;
using Fullstack_Example.Architecture.Application.Services;
using System.Text.Json.Serialization;

namespace Fullstack_Example.Architecture.Application
{
    public static class ConfigureServices
    {
        public static IServiceCollection UseApplicationServices(this IServiceCollection services)
        {
            services.AddAutoMapper(typeof(MyProfile));

            #region Entity services
            //services.UseEntityServices<Teacher>();
            //services.UseEntityServices<Learner>();
            //services.UseEntityServices<Skill>();
            //services.UseEntityServices<Enrollment>();

            //services.UseEntityServices<Topic>();
            //services.UseEntityServices<Course>();
            #endregion

            services.AddScoped<IEntityService, EntityService>();

            services.AddControllers().AddJsonOptions(x =>
                x.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles);

            //services.UseHotChocolate();
            services.AddSingleton<CommandService>();

            return services;
        }

        public static IServiceCollection UseEntityServices<TEntity>(this IServiceCollection services) where TEntity : BaseEntity
        {
            services.AddScoped<IEntityService, EntityService>();
            return services;
        }

        public static IServiceCollection UseHotChocolate(this IServiceCollection services)
        {
            services
                .AddGraphQLServer()
                .InitializeOnStartup()
                .RegisterDbContext<AppDbContext>()
                .AddProjections()
                .AddFiltering()
                .AddSorting()

                // add queries
                .AddQueryType<Query>()

                //.AddQueryType(q => q.Name("Query"))
                //.AddType<TopicTypeExtension>()
                //.AddType<PetResolver>()

                // add mutations
                .AddMutationType<Mutation>()

                //.AddMutationType(m => m.Name("Mutation"))
                //.AddType<CountryMutateTypeExtension>()
                //.AddType<PetsMutateResolver>()
                ;
            return services;
        }
    }
}
