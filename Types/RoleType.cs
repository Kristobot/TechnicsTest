using TechnicsTest.GraphQL.Enums;

namespace TechnicsTest.GraphQL.Types
{
    public class RoleType : EnumType<Role>
    {
        protected override void Configure(IEnumTypeDescriptor<Role> descriptor)
        {
            descriptor.Value(Role.Admin);
            descriptor.Value(Role.Librarian);
            descriptor.Value(Role.Client);
        }
    }
}
