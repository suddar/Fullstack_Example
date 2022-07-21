namespace Fullstack_Example.Architecture.Application.GraphQL.MutationResolver
{
    public class CountryMutateResolver
    {
        public string SaveCountry(CountryModel model)
        {
            // implement logic to save to database or datasource
            return model.Name;
        }
    }
}
