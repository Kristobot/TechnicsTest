using Microsoft.EntityFrameworkCore;
using TechnicsTest.GraphQL.Models;
using TechnicsTest.GraphQL.Persistence;
using TechnicsTest.GraphQL.Requests;

namespace TechnicsTest.GraphQL.Services
{
    public class BookService
    {
        private readonly LibraryDbContext context;

        public BookService(LibraryDbContext context)
        {
            this.context = context;
        }
        public async Task<Book> createBook(BookRequest data)
        {
            ICollection<Genre> genres = await GetGenres(data.genreIds);
            var book = new Book
            {
                Title = data.Title,
                Description = data.Description,
                PublishedDate = data.PublishedDate,
                AuthorID = data.AuthorID,
                Genres = (ICollection<BookGenre>)genres.Select(b => new BookGenre
                {
                    BookGenreID = Guid.NewGuid(),
                    GenreID = b.GenreID
                }).ToList()
            };
            await context.Books.AddAsync(book);
            await context.SaveChangesAsync();

            return book;
        }

        private async Task<ICollection<Genre>> GetGenres(List<Guid> genreIds)
        {
            List<Genre> genres = new List<Genre>();

            foreach (var id in genreIds)
            {
                var genre = await context.Genres.Where(g => g.GenreID == id).FirstAsync();
                if (genre != null)
                    genres.Add(genre);
            }

            return genres;
        }
    }
}
