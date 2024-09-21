using Bogus;
using TechnicsTest.GraphQL.Models;

namespace TechnicsTest.GraphQL.Persistence.Fakers
{
    public class AuthorFaker : Faker<Author>
    {
        public AuthorFaker()
        {
            RuleFor(a => a.AuthorID, f => Guid.NewGuid());
            RuleFor(a => a.Name, f => f.Name.FirstName());
            RuleFor(a => a.LastName, f => f.Name.LastName());
        }
    }
}
