using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using PopFake.Models;

namespace PopFake.Data.Seeders;

public class CitySeeder
{
    public void Seed(ModelBuilder modelBuilder)
    {
       
            modelBuilder.Entity<City>().HasData(new City
            {
                Id = 1,
                Name = "Rio de Janeiro",
                Timezone = "America/Sao_Paulo"
            });
           
    }
}
