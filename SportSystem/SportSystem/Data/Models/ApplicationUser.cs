using Microsoft.AspNetCore.Identity;

namespace SportSystem.Data.Models
{
    public class ApplicationUser : IdentityUser
    {


        public string FirstName { get; set; }
        public string Lastname { get; set; }

        public Guid ApplicationUserRoleId { get; set; }

    }
}
