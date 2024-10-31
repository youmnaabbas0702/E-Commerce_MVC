using Microsoft.AspNetCore.Identity;

namespace eCommerce.DAL.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public DateTime CreatedDate { get; set; }
    }
}
