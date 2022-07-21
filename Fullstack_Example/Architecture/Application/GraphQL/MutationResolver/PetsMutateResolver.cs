namespace Fullstack_Example.Architecture.Application.GraphQL.MutationResolver
{
    [ExtendObjectType(Name = "Mutation")]
    public class PetsMutateResolver
    {
        public string SavePet(PetModel model)
        {
            //logic save data to database
            return model.Name;
        }
    }
}
