namespace PopFake.Models;

public class RefreshToken
{
    public required string Token { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime Expired { get; set; } = DateTime.Now.AddMonths(6);
}