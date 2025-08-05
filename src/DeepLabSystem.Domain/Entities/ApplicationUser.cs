using Microsoft.AspNetCore.Identity;

namespace DeepLabSystem.Domain.Entities
{
    public class ApplicationUser : IdentityUser
    {
        public List<RefreshToken> RefreshTokens { get; set; }
    }
}
