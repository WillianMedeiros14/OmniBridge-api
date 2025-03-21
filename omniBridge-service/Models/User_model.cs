using Microsoft.AspNetCore.Identity;
using omniBridge_service.Models;

namespace omniBridge_service.Models
{
    public class UserModel : IdentityUser
    {
        public virtual AddressModel Address { get; set; }
    }
}
