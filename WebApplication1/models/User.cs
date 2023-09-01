using Microsoft.AspNetCore.Identity;

namespace WebApplication1.models
{
    public class User : IdentityUser
    {
        public string Firstname { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string MobileNumber { get; set; }
    }
}
