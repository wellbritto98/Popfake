using Microsoft.AspNetCore.Identity;

namespace PopFake.Models;

public class User : IdentityUser
{
    public string Nickname { get; set; }
    public DateTime RegisteredAt { get; set; }
    public DateTime DataNascimento { get; set; }
    public DateTime? LastLoginAt { get; set; }
    public string RefreshToken { get; set; } = string.Empty;
    public DateTime TokenExpiredAt { get; set; }
    public DateTime TokenCreatedAt { get; set; }
    public virtual ICollection<Character> Characters { get; set; }
}