using Bogus;
using TechnicsTest.GraphQL.Models;

namespace TechnicsTest.GraphQL.Persistence.Fakers
{
    public class GenreFaker : Faker<Genre>
    {
        public GenreFaker()
        {
            RuleFor(g => g.GenreID, f => Guid.NewGuid());
            RuleFor(g => g.Name, f => f.Commerce.Categories(1)[0]);
        }
    }
}
