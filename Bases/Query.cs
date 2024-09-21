using Microsoft.EntityFrameworkCore;
using TechnicsTest.GraphQL.Models;
using TechnicsTest.GraphQL.Persistence;

namespace TechnicsTest.GraphQL.Bases
{
    public class Query
    {
        public async Task<List<Book>> GetBooks([Service(ServiceKind.Resolver)] LibraryDbContext context)
        {
            return await context.Books.Include(b => b.Genres).ToListAsync();
        }

        public async Task<Book> GetBookById(Guid bookID, [Service(ServiceKind.Resolver)] LibraryDbContext context)
        {
            return await context.Books.Include(b => b.Genres).Where(b => b.BookID == bookID).FirstAsync();
        }

        public async Task<List<Genre>> GetGenres([Service(ServiceKind.Resolver)] LibraryDbContext context)
        {
            return await context.Genres.ToListAsync();
        }

        public async Task<List<Author>> GetAuthors([Service(ServiceKind.Resolver)] LibraryDbContext context)
        {
            return await context.Authors.ToListAsync();
        }
    }
}
