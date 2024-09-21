using TechnicsTest.GraphQL.Models;

namespace TechnicsTest.GraphQL.Types
{
    public class UserType : ObjectType<User>
    {
        protected override void Configure(IObjectTypeDescriptor<User> descriptor)
        {
            descriptor.Field(u => u.UserID).Type<UuidType>();
            descriptor.Field(u => u.Role).Type<RoleType>();
            descriptor.Field(u => u.Name).Type<StringType>();
            descriptor.Field(u => u.Email).Type<StringType>();
            descriptor.Field(u => u.Password).Type<StringType>();
        }
    }
}
