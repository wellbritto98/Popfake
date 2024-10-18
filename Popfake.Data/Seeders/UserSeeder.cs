using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using PopFake.Models;

namespace PopFake.Data.Seeders;

public class UserSeeder
{
    public void Seed(ModelBuilder modelBuilder)
    {
        var hasher = new PasswordHasher<IdentityUser>();
        for (int i = 1; i <= 12; i++)
        {
            var user = new User
            {
                Id = Guid.NewGuid().ToString(), // primary key
                UserName = $"user{i}",
                NormalizedUserName = $"USER{i}",
                Email = $"user{i}@example.com",
                NormalizedEmail = $"USER{i}@EXAMPLE.COM",
                EmailConfirmed = true,
                PasswordHash = hasher.HashPassword(null, "Password@123"),
                SecurityStamp = string.Empty,
                Nickname = $"User {i}",
                RegisteredAt = DateTime.Now,
                DataNascimento = new DateTime(1980, 1, 1),

            };
            modelBuilder.Entity<User>().HasData(user);
            modelBuilder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string>
                {
                    RoleId = "2c5e174e-3b0e-446f-86af-483d56fd7211",
                    UserId = user.Id
                }
            );
        }
    }
}