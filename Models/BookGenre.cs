using System.ComponentModel.DataAnnotations;

namespace TechnicsTest.GraphQL.Models
{
    public class BookGenre
    {
        [Key]
        public Guid BookGenreID { get; set; }
        public Guid BookID { get; set; }
        public Guid GenreID { get; set; }

        public virtual Book Books { get; set; }
        public virtual Genre Genre { get; set; }
    }
}
