namespace TechnicsTest.GraphQL.Models
{
    public class Genre
    {
        public Guid GenreID { get; set; }
        public string Name { get; set; }

        public virtual ICollection<BookGenre> Books { get; set; }
    }
}
