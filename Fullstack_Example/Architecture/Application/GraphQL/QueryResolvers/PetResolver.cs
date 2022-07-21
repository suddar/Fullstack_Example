namespace Fullstack_Example.Architecture.Application.GraphQL.QueryResolvers
{
    [ExtendObjectType(Name = "Query")]
    public class PetResolver
    {
        public string YourPet()
        {
            return "Dog";
        }
    }
}
