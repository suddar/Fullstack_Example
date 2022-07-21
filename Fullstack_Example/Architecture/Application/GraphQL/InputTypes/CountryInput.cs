namespace Fullstack_Example.Architecture.Application.GraphQL.InputTypes
{
    public class CountryInput : InputObjectType<CountryModel>
    {
        protected override void Configure(IInputObjectTypeDescriptor<CountryModel> descriptor)
        {
            descriptor.Name("CountryInput");
            descriptor.Field(_ => _.Id)
            .Type<IntType>()
            .Name("Id");

            descriptor.Field(_ => _.Name)
            .Type<StringType>()
            .Name("Name");
        }
    }
}
