using Fullstack_Example.Architecture.Application.GraphQL.InputTypes;
using Fullstack_Example.Architecture.Application.GraphQL.MutationResolver;

namespace Fullstack_Example.Architecture.Application.GraphQL.CoutnryMutateResolver
{
    public class CountryMutateTypeExtension : ObjectTypeExtension
    {
        protected override void Configure(IObjectTypeDescriptor descriptor)
        {
            descriptor.Name("Mutation");
            descriptor.Field("SaveCountry")
            .ResolveWith<CountryMutateResolver>(m => m.SaveCountry(default))
            .Argument("model", _ => _.Type<CountryInput>())
            .Type<StringType>()
            .Name("SaveCountry");
        }
    }
}
