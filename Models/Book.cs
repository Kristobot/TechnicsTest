namespace TechnicsTest.GraphQL.Models
{
    public class Book
    {
        public Guid BookID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateOnly PublishedDate { get; set; }
        public Guid AuthorID { get; set; }

        public virtual Author Author { get; set; }
        public virtual ICollection<BookGenre> Genres { get; set; }
    }
}
