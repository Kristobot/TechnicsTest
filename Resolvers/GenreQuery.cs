using Microsoft.EntityFrameworkCore;
using TechnicsTest.GraphQL.Bases;
using TechnicsTest.GraphQL.Models;
using TechnicsTest.GraphQL.Persistence;
using TechnicsTest.GraphQL.Types;

namespace TechnicsTest.GraphQL.Resolvers
{
    public class GenreQuery : ObjectTypeExtension<Query>
    {
        public async Task<List<Genre>> GetGenresByBookId([Parent]Book book, [Service(ServiceKind.Resolver)] LibraryDbContext context)
        {
            return await context.BookGenres.Where(b => b.BookID == book.BookID).Select(b => b.Genre).ToListAsync();
        }
    }
}
