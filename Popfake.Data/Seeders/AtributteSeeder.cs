using Microsoft.EntityFrameworkCore;
using PopFake.Models;

namespace PopFake.Data.Seeders
{
    public class AtributteSeeder
    {
        public void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Atributte>().HasData(
                new Atributte { Id = 1, Name = "Dexterity", Description = "The ability to perform tasks with precision and agility." },
                new Atributte { Id = 2, Name = "Strength", Description = "The physical power and ability to perform tasks requiring muscular effort." },
                new Atributte { Id = 3, Name = "Intelligence", Description = "The ability to learn, understand, and apply knowledge." },
                new Atributte { Id = 4, Name = "Constitution", Description = "The physical endurance and ability to withstand adversities." },
                new Atributte { Id = 5, Name = "Creativity", Description = "The ability to innovate and think in an original and inventive way." }
            );
        }
    }
}
