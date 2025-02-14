using Microsoft.AspNetCore.Identity;

namespace BookStore.Models
{
    public class Admin : IdentityUser
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }

    }
}
