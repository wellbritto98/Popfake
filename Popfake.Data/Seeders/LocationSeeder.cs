using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using PopFake.Models;

namespace PopFake.Data.Seeders;

public class LocationSeeder
{
    public void Seed(ModelBuilder modelBuilder)
    {

        Location[] locations =
        {
            new Location
            {
                Id = 1,
                Name = "Praia de Copacabana",
                Quality = 5,
                TypeId = LocationType.Beach,
                CityId = 1,
                CompanyId = 1,
                Money = 1000000
            },

            new Location
            {
                Id = 2,
                Name = "Parque do Flamengo",
                Quality = 5,
                TypeId = LocationType.Park,
                CityId = 1,
                CompanyId = 1,
                Money = 1000000
            },

            new Location
            {
                Id = 3,
                Name = "Parque Olímpico",
                Quality = 5,
                TypeId = LocationType.OlympicPark,
                CityId = 1,
                CompanyId = 1,
                Money = 1000000
            },

            new Location
            {
                Id = 4,
                Name = "Academia de Ginástica",
                Quality = 5,
                TypeId = LocationType.Gyms,
                CityId = 1,
                CompanyId = 1,
                Money = 1000000
            },

            new Location
            {
                Id = 5,
                Name = "Hotel Copacabana Palace",
                Quality = 5,
                TypeId = LocationType.Hotels,
                CityId = 1,
                CompanyId = 1,
                Money = 1000000
            },

            new Location
            {
                Id = 6,
                Name = "Restaurante Fasano",
                Quality = 5,
                TypeId = LocationType.Restaurants,
                CityId = 1,
                CompanyId = 1,
                Money = 1000000
            },

            new Location
            {
                Id = 7,
                Name = "Loja de Artigos Esportivos",
                Quality = 5,
                TypeId = LocationType.ArticleStore,
                CityId = 1,
                CompanyId = 1,
                Money = 1000000
            },

            new Location
            {
                Id = 8,
                Name = "Centro de Treinamento",
                Quality = 5,
                TypeId = LocationType.TrainingCenter,
                CityId = 1,
                CompanyId = 1,
                Money = 1000000
            }
        };
        modelBuilder.Entity<Location>().HasData(locations);
    }
}

