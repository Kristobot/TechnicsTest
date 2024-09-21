using HotChocolate.Subscriptions;
using TechnicsTest.GraphQL.Models;
using TechnicsTest.GraphQL.Persistence;
using TechnicsTest.GraphQL.Requests;
using TechnicsTest.GraphQL.Services;
using TechnicsTest.GraphQL.Types;

namespace TechnicsTest.GraphQL.Bases
{
    public class Mutation
    {
        public async Task<User> createUser(UserRequest data, [Service(ServiceKind.Resolver)]LibraryDbContext context, ITopicEventSender sender)
        {
            var user = new User
            {
                UserID = Guid.NewGuid(),
                Email = data.Email,
                Name = data.Name,
                Password = data.Password,
                Role = data.Role,
            };
            await context.Users.AddAsync(user);
            await context.SaveChangesAsync();
            await sender.SendAsync(nameof(Subscriptions.UserAdded), user);
            return user;
        }

        public async Task<Author> createAuthor(AuthorRequest data, [Service(ServiceKind.Resolver)] LibraryDbContext context, ITopicEventSender sender)
        {
            var author = new Author
            {
                AuthorID = Guid.NewGuid(),
                Name = data.Name,
                LastName = data.LastName,
            };
            await context.Authors.AddAsync(author);
            await context.SaveChangesAsync();
            await sender.SendAsync(nameof(Subscriptions.AuthorAdded), author);
            return author;
        }

        public async Task<Book> createBook(BookRequest data,[Service]BookService bookService, ITopicEventSender sender)
        {
            var book = await bookService.createBook(data);
            await sender.SendAsync(nameof(Subscriptions.BookAdded), book);
            await sender.SendAsync(nameof(Subscriptions.BookAddedByAuthorID), book);
            return book;
        }
    }
}
