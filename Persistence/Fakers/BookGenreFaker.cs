using Bogus;
using TechnicsTest.GraphQL.Models;

namespace TechnicsTest.GraphQL.Persistence.Fakers
{
    public class BookGenreFaker : Faker<BookGenre>
    {
        public BookGenreFaker(Book book, List<Genre> genres)
        {
            RuleFor(bg => bg.BookGenreID, f => Guid.NewGuid());
            RuleFor(bg => bg.BookID, f => book.BookID);
            RuleFor(bg => bg.GenreID, f => f.PickRandom(genres).GenreID);
        }
    }
}
