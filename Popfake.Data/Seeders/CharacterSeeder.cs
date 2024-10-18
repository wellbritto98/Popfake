using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using PopFake.Models;
using System;

namespace PopFake.Data.Seeders
{
    public class CharacterSeeder
    {
        public void Seed(ModelBuilder modelBuilder)
        {
            var hasher = new PasswordHasher<IdentityUser>();
            // Criação de 4 usuários
            User[] useruniques =
            {
                new User
                {
                    Id = "1",
                    UserName = "userunique1",
                    NormalizedUserName = "USERUNIQUE1",
                    Email = "userunique1@email.com",
                    NormalizedEmail = "USERUNIQUE1@EMAIL.COM",
                    EmailConfirmed = true,
                    PasswordHash = hasher.HashPassword(null, "Password@123"),
                    SecurityStamp = string.Empty,
                    Nickname = "User One",
                    RegisteredAt = DateTime.Now,
                    DataNascimento = new DateTime(1980, 1, 1),
                },
                new User
                {
                    Id = "2",
                    UserName = "userunique2",
                    NormalizedUserName = "USERUNIQUE2",
                    Email = "userunique2@email.com",
                    NormalizedEmail = "USERUNIQUE2@EMAIL.COM",
                    EmailConfirmed = true,
                    PasswordHash = hasher.HashPassword(null, "Password@123"),
                    SecurityStamp = string.Empty,
                    Nickname = "User Two",
                    RegisteredAt = DateTime.Now,
                    DataNascimento = new DateTime(1985, 2, 2),
                },
                new User
                {
                    Id = "3",
                    UserName = "userunique3",
                    NormalizedUserName = "USERUNIQUE3",
                    Email = "userunique3@email.com",
                    NormalizedEmail = "USERUNIQUE3@EMAIL.COM",
                    EmailConfirmed = true,
                    PasswordHash = hasher.HashPassword(null, "Password@123"),
                    SecurityStamp = string.Empty,
                    Nickname = "User Three",
                    RegisteredAt = DateTime.Now,
                    DataNascimento = new DateTime(1990, 3, 3),
                },
                new User
                {
                    Id = "4",
                    UserName = "userunique4",
                    NormalizedUserName = "USERUNIQUE4",
                    Email = "userunique4@email.com",
                    NormalizedEmail = "USERUNIQUE4@EMAIL.COM",
                    EmailConfirmed = true,
                    PasswordHash = hasher.HashPassword(null, "Password@123"),
                    SecurityStamp = string.Empty,
                    Nickname = "User Four",
                    RegisteredAt = DateTime.Now,
                    DataNascimento = new DateTime(1995, 4, 4),
                }
            };

            // Adiciona os usuários ao modelo
            modelBuilder.Entity<User>().HasData(useruniques);

            // Criação de 3 personagens para cada usuário, com datas de nascimento em outubro de 2024
            Character[] characters =
            {
                new Character { Id = 1, UserId = "1", FirstName = "John", LastName = "Doe", Age = 25, Gender = "Male", BirthAt = new DateTime(2024, 10, 5), BirthCityId = 1, CurrentLocationId = 1 },
                new Character { Id = 2, UserId = "1", FirstName = "Jane", LastName = "Doe", Age = 22, Gender = "Female", BirthAt = new DateTime(2024, 10, 6), BirthCityId = 1, CurrentLocationId = 1 },
                new Character { Id = 3, UserId = "1", FirstName = "Bob", LastName = "Smith", Age = 30, Gender = "Male", BirthAt = new DateTime(2024, 10, 7), BirthCityId = 1, CurrentLocationId = 1 },

                new Character { Id = 4, UserId = "2", FirstName = "Alice", LastName = "Johnson", Age = 28, Gender = "Female", BirthAt = new DateTime(2024, 10, 8), BirthCityId = 1, CurrentLocationId = 1 },
                new Character { Id = 5, UserId = "2", FirstName = "Charlie", LastName = "Brown", Age = 33, Gender = "Male", BirthAt = new DateTime(2024, 10, 9), BirthCityId = 1, CurrentLocationId = 1 },
                new Character { Id = 6, UserId = "2", FirstName = "Dave", LastName = "Wilson", Age = 35, Gender = "Male", BirthAt = new DateTime(2024, 10, 10), BirthCityId = 1, CurrentLocationId = 1 },

                new Character { Id = 7, UserId = "3", FirstName = "Emily", LastName = "Davis", Age = 21, Gender = "Female", BirthAt = new DateTime(2024, 10, 11), BirthCityId = 1, CurrentLocationId = 1 },
                new Character { Id = 8, UserId = "3", FirstName = "Frank", LastName = "Miller", Age = 27, Gender = "Male", BirthAt = new DateTime(2024, 10, 12), BirthCityId = 1, CurrentLocationId = 1 },
                new Character { Id = 9, UserId = "3", FirstName = "Grace", LastName = "Lee", Age = 19, Gender = "Female", BirthAt = new DateTime(2024, 10, 13), BirthCityId = 1, CurrentLocationId = 1 },

                new Character { Id = 10, UserId = "4", FirstName = "Hank", LastName = "Taylor", Age = 23, Gender = "Male", BirthAt = new DateTime(2024, 10, 14), BirthCityId = 1, CurrentLocationId = 1 },
                new Character { Id = 11, UserId = "4", FirstName = "Ivy", LastName = "White", Age = 26, Gender = "Female", BirthAt = new DateTime(2024, 10, 15), BirthCityId = 1, CurrentLocationId = 1 },
                new Character { Id = 12, UserId = "4", FirstName = "Jack", LastName = "Black", Age = 32, Gender = "Male", BirthAt = new DateTime(2024, 10, 16), BirthCityId = 1, CurrentLocationId = 1 }
            };

            // Adiciona os personagens ao modelo
            modelBuilder.Entity<Character>().HasData(characters);
        }
    }
}
