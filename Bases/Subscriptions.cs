using TechnicsTest.GraphQL.Models;

namespace TechnicsTest.GraphQL.Bases
{
    public class Subscriptions
    {
        [Subscribe]
        public Book BookAdded([EventMessage] Book book)
        {
            return book;
        }
        [Subscribe]
        public User UserAdded([EventMessage] User user)
        {
            return user;
        }
        [Subscribe]
        public Author AuthorAdded([EventMessage] Author author)
        {
            return author;
        }

        [Subscribe]
        public Book BookAddedByAuthorID([EventMessage] Book book, [Argument]Guid authorId)
        {
            return book.AuthorID == authorId ? book : null;
        }
    }
}
