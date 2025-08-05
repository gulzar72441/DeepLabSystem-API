using System.ComponentModel.DataAnnotations.Schema;

namespace DeepLabSystem.Domain.Entities
{
    public class RefreshToken
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public string Token { get; set; }
        public DateTime Expires { get; set; }
        public bool IsExpired => DateTime.UtcNow >= Expires;
        public DateTime Created { get; set; }
        public DateTime? Revoked { get; set; }
        public bool IsActive => Revoked == null && !IsExpired;

        [ForeignKey(nameof(UserId))]
        public ApplicationUser User { get; set; }
    }
}
