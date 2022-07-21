using Fullstack_Example.Architecture.Application.GraphQL.QueryResolvers;

namespace Fullstack_Example.Architecture.Application.GraphQL.QueryTypes
{
    public class TopicTypeExtension : ObjectTypeExtension
    {
        protected override void Configure(IObjectTypeDescriptor descriptor)
        {
            descriptor.Name("Query");

            descriptor.Field("GetHomeCounry")
            .ResolveWith<TopicResolver>(_ => _.GetHomeCounry())
            .Type<StringType>()
            .Name("HomeCountry");

        }
    }
}
