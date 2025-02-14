using System.ComponentModel.DataAnnotations;

namespace BookStore.Models
{
    public class Catalog
    {
        public int Id { get; set; }
        [StringLength(100)]
        [Required]
        public string Name { get; set; }
        public string Desc { get; set; }


        // Navigation Property for related Book entities
        public virtual List<Book> Books { get; set; } = new List<Book>();
    }
}
