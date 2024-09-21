using TechnicsTest.GraphQL.Models;
using TechnicsTest.GraphQL.Resolvers;

namespace TechnicsTest.GraphQL.Types
{
    public class AuthorType : ObjectType<Author>
    {
        protected override void Configure(IObjectTypeDescriptor<Author> descriptor)
        {
            descriptor.Field(a => a.AuthorID).Type<UuidType>();
            descriptor.Field(a => a.Name).Type<StringType>();
            descriptor.Field(a => a.LastName).Type<StringType>();
            descriptor.Field(a => a.Books).Type<ListType<BookType>>().ResolveWith<BookQuery>(b => b.GetBooksByAuthorId(default!,default!));
        }
    }
}
