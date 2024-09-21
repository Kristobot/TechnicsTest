using Microsoft.EntityFrameworkCore;
using TechnicsTest.GraphQL.Bases;
using TechnicsTest.GraphQL.Models;
using TechnicsTest.GraphQL.Persistence;
using TechnicsTest.GraphQL.Types;

namespace TechnicsTest.GraphQL.Resolvers
{
    public class BookQuery : ObjectTypeExtension<Query>
    {
        public async Task<List<Book>> GetBooksByGenreId([Parent]Genre genre, [Service(ServiceKind.Resolver)] LibraryDbContext context)
        {
            return await context.BookGenres.Where(bg => bg.GenreID == genre.GenreID).Select(bg => bg.Books).ToListAsync();
        }

        public async Task<List<Book>> GetBooksByAuthorId([Parent]Author author, [Service(ServiceKind.Resolver)] LibraryDbContext context)
        {
            return await context.Books.Where(b => b.AuthorID == author.AuthorID).ToListAsync();
        }

    }
}
