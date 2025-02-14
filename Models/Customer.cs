using Microsoft.AspNetCore.Identity;

namespace BookStore.Models
{
    public class Customer : IdentityUser
    {
        //public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }

        public virtual List<Order> Orders { get; set; } = new List<Order>();
    }
}
