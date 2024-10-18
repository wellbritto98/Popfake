using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using PopFake.Models;

namespace PopFake.Data.Seeders;

public class CompanySeeder
{
    public void Seed(ModelBuilder modelBuilder)
    {
       
            modelBuilder.Entity<Company>().HasData(new Company
            {
                Id = 1,
                Name = "Prefeitura do Rio de Janeiro",
                CityId = 1,
                CompanyType = CompanyType.Public,
                Money = 1000000000
            });
           
    }
}

