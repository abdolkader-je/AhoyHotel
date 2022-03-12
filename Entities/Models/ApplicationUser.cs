using Microsoft.AspNetCore.Identity;

namespace Entities.Models
{
    public class ApplicationUser: IdentityUser
    {
        public ApplicationUser()
        {
            IsDeleted = false;
            CreatedDate = DateTime.Now;
           // Id = Guid.NewGuid();    
        }
        public DateTime CreatedDate { get; set; }
        public bool  IsDeleted { get; set; }
    }
}
