using Microsoft.AspNetCore.Identity;
namespace WebApplication2.Data
{
    public class User:IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public DateTime RegisterOn { get; set; }
    }
}
