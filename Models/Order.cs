using System.ComponentModel.DataAnnotations.Schema;

namespace BookStore.Models
{
    public class Order
    {
        public int Id { get; set; }


        [Column(TypeName = "date")]
        public DateOnly OrderDate { get; set; }

        [Column(TypeName = "money")]
        public decimal TotalPrice { get; set; }

        public string Status { get; set; }

        //public virtual List<OrderDetails> OrderDetails { get; set; } = new List<OrderDetails>();

        [ForeignKey("Customer")]
        public string CustomerId { get; set; }

        public virtual Customer Customer { get; set; }

        public virtual List<OrderDetails> OrderDetails { get; set; } = new List<OrderDetails>();
    }
}
