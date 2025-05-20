using Microsoft.AspNetCore.Identity;

namespace ProjektSklepTI.Models.Users
{
    public class AppUser : IdentityUser<int>
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }
    }
}