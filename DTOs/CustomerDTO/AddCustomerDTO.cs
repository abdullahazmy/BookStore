using System.ComponentModel.DataAnnotations;

namespace BookStore.DTOs.Customer
{
    public class AddCustomerDTO
    {
        public string Name { get; set; }
        [RegularExpression(@"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$", ErrorMessage = "Invalid email format.")]
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }

        [Required]
        public string UserName { get; set; }
        [Required]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d).{8,15}$", ErrorMessage = "Password must be between 8 and 15 characters and contain at least one uppercase letter, one lowercase letter, and one number.")]
        public string Password { get; set; }

        //[Compare("Password", ErrorMessage = "Password and confirm password must be the same.")]
        //public string ConfirmPassword { get; set; }
    }
}
