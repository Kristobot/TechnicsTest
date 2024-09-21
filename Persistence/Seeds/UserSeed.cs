using Bogus;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TechnicsTest.GraphQL.Models;

namespace TechnicsTest.GraphQL.Persistence.Seeds
{
    public class UserSeed : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasData(new User
            {
                UserID = Guid.NewGuid(),
                Name = "KingCris",
                Email = "test1@example.com",
                Password = "contraseña01",
                Role = Enums.Role.Admin,
            });
        }
    }
}
