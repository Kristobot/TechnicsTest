using TechnicsTest.GraphQL.Models;
using TechnicsTest.GraphQL.Resolvers;

namespace TechnicsTest.GraphQL.Types
{
    public class GenreType : ObjectType<Genre>
    {
        protected override void Configure(IObjectTypeDescriptor<Genre> descriptor)
        {
            descriptor.Field(g => g.GenreID).Type<UuidType>();
            descriptor.Field(g => g.Name).Type<StringType>();
            descriptor.Field(g => g.Books).Type<ListType<BookType>>().ResolveWith<BookQuery>(bq => bq.GetBooksByGenreId(default!,default!));
        }
    }
}
