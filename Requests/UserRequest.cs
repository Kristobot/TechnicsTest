using TechnicsTest.GraphQL.Enums;

namespace TechnicsTest.GraphQL.Requests
{
    public class UserRequest
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public Role Role { get; set; }
    }
}
