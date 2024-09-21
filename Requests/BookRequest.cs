namespace TechnicsTest.GraphQL.Requests
{
    public class BookRequest
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateOnly PublishedDate { get; set; }
        public Guid AuthorID { get; set; }

        public List<Guid> genreIds { get; set; }
    }
}
