using TechnicsTest.GraphQL.Models;
using TechnicsTest.GraphQL.Resolvers;

namespace TechnicsTest.GraphQL.Types
{
    public class BookType : ObjectType<Book>
    {
        protected override void Configure(IObjectTypeDescriptor<Book> descriptor)
        {
            descriptor.Field(b => b.BookID).Type<UuidType>();
            descriptor.Field(b => b.Title).Type<StringType>();
            descriptor.Field(b => b.Description).Type<StringType>();
            descriptor.Field(b => b.PublishedDate).Type<DateType>();
            descriptor.Field(b => b.Author).Type<AuthorType>();
            descriptor.Field(b => b.Genres).ResolveWith<GenreQuery>(g => g.GetGenresByBookId(default!,default!)).Type<ListType<GenreType>>();
        }
    }
}
