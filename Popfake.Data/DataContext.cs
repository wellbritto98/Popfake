using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PopFake.Data.Seeders;
using PopFake.Models;
using PopFake.Models;


namespace PopFake.Data;

public class DataContext : IdentityDbContext<User>
{
    public DbSet<ExampleEntity> Examples { get; set; }

    public DbSet<City> Cities { get; set; }
    public DbSet<Company> Companies { get; set; }
    public DbSet<Location> Locations { get; set; }
    public DbSet<Character> Characters { get; set; }
    public DbSet<CompanyShareholder> CompanyShareholders { get; set; }
    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        
        modelBuilder.Entity<IdentityRole>().HasData(new IdentityRole
        { Id = "2c5e174e-3b0e-446f-86af-483d56fd7210", Name = "Admin", NormalizedName = "ADMIN".ToUpper() });
        modelBuilder.Entity<IdentityRole>().HasData(new IdentityRole
        { Id = "2c5e174e-3b0e-446f-86af-483d56fd7211", Name = "Player", NormalizedName = "PLAYER".ToUpper() });
        
        SeedDatabase(modelBuilder);
    }
        private void SeedDatabase(ModelBuilder modelBuilder)
        {
            new UserSeeder().Seed(modelBuilder);
            new CitySeeder().Seed(modelBuilder);
            new CompanySeeder().Seed(modelBuilder);
            new LocationSeeder().Seed(modelBuilder);
            new CharacterSeeder().Seed(modelBuilder);
        }
}
