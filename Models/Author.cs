namespace TechnicsTest.GraphQL.Models
{
    public class Author
    {
        public Guid AuthorID { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }

        public virtual ICollection<Book> Books { get; set; }
    }
}
