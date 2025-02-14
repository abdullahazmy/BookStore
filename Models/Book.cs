using System.ComponentModel.DataAnnotations.Schema;

namespace BookStore.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }

        [Column(TypeName = "money")]
        public decimal Price { get; set; }
        public int Stock { get; set; }

        [Column(TypeName = "date")]
        public DateOnly PublishDate { get; set; }

        // Foreign Key for the Catalog Navigation Property
        [ForeignKey("Catalog")]
        public int CatalogId { get; set; }
        public virtual Catalog Catalog { get; set; }

        // Foreign Key for the Author Navigation Property
        [ForeignKey("Author")]
        public int AuthorId { get; set; }
        public virtual Author Author { get; set; }

        // Navigation Property for related OrderDetails entities
        public virtual List<OrderDetails> OrderDetails { get; set; } = new List<OrderDetails>();

    }
}
