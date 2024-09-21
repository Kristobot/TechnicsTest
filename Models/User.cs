using TechnicsTest.GraphQL.Enums;

namespace TechnicsTest.GraphQL.Models
{
    public class User
    {
        public Guid UserID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public Role Role { get; set; }
    }
}
