using Microsoft.EntityFrameworkCore;
using TechnicsTest.GraphQL.Models;
using TechnicsTest.GraphQL.Persistence.Fakers;

namespace TechnicsTest.GraphQL.Persistence
{
    public class LibraryDbContext : DbContext
    {
        public LibraryDbContext(DbContextOptions<LibraryDbContext> options)
            : base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<BookGenre> BookGenres { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(LibraryDbContext).Assembly);

            var authors = new AuthorFaker().Generate(5);
            var genres = new GenreFaker().Generate(10);

            List<Book> books = new List<Book>();

            foreach (var author in authors)
            {
                books.AddRange(new BookFaker(author).Generate(new Random().Next(1, 5)));
            }

            List<BookGenre> bookGenres = new List<BookGenre>();

            foreach (var book in books)
            {
                bookGenres.AddRange(new BookGenreFaker(book, genres).Generate(new Random().Next(1, 6)));
            }

            modelBuilder.Entity<Author>().HasData(authors);
            modelBuilder.Entity<Genre>().HasData(genres);
            modelBuilder.Entity<Book>().HasData(books);
            modelBuilder.Entity<BookGenre>().HasData(bookGenres);
        }
    }
}
