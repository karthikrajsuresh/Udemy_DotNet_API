using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace HotelListing.API.Core.Models.Users
{
    public class LoginDto
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [StringLength(15, ErrorMessage = "Your Password is Limited to {2} to {1} Characters", MinimumLength = 6)]
        public string Password { get; set; }
    }
}
