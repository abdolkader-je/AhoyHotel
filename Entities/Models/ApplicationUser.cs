using Microsoft.AspNetCore.Identity;

namespace Entities.Models
{
    public class ApplicationUser: IdentityUser
    {
        public ApplicationUser()
        {
            IsDeleted = false;
        }
        public bool  IsDeleted { get; set; }
    }
}
