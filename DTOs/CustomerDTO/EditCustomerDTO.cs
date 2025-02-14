using System.ComponentModel.DataAnnotations;

namespace BookStore.DTOs.CustomerDTO
{
    public class EditCustomerDTO
    {
        [Required]
        public string Id { get; set; }
        public string Name { get; set; }
        [RegularExpression(@"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$", ErrorMessage = "Invalid email format.")]
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }

        [Required]
        public string UserName { get; set; }

    }
}
