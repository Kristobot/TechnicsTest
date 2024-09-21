using Bogus;
using TechnicsTest.GraphQL.Models;

namespace TechnicsTest.GraphQL.Persistence.Fakers
{
    public class BookFaker : Faker<Book>
    {
        public BookFaker(Author author)
        {
            RuleFor(b => b.BookID, f => Guid.NewGuid());
            RuleFor(b => b.Title, f => f.Lorem.Sentence(3));
            RuleFor(b => b.Description, f => f.Lorem.Sentences(2));
            RuleFor(b => b.PublishedDate, f => f.Date.BetweenDateOnly(DateOnly.Parse("1999/01/01"), DateOnly.FromDateTime(DateTime.Now)));
            RuleFor(b => b.AuthorID, f => author.AuthorID);
        }
    }
}
