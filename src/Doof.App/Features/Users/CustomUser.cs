using Doof.App.Features.Recipes;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace Doof.App.Features.Users;

public class CustomUser : IdentityUser
{
    public ICollection<Recipe> Recipes { get; set; } = [];


    public static void Seed(ModelBuilder builder)
    {
        var passwordHasher = new PasswordHasher<CustomUser>();

        builder.Entity<CustomUser>().HasData(
            new CustomUser
            {
                Id = "3243c86d-7438-48cb-9a75-7d9bff08b725",
                UserName = "adrian@gmail.com",
                NormalizedUserName = "ADRIAN@GMAIL.COM",
                Email = "adrian@gmail.com",
                NormalizedEmail = "ADRIAN@GMAIL.COM",
                EmailConfirmed = true,
                SecurityStamp = Guid.NewGuid().ToString(),
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                PhoneNumber = null,
                PhoneNumberConfirmed = false,
                TwoFactorEnabled = false,
                LockoutEnd = null,
                LockoutEnabled = true,
                AccessFailedCount = 0,
                PasswordHash = passwordHasher.HashPassword(null, "Admin123!")
            },
            new CustomUser
            {
                Id = "0462034d-8221-4cb2-8a68-db22c1028c5f",
                UserName = "matilda@gmail.com",
                NormalizedUserName = "MATILDA@GMAIL.COM",
                Email = "matilda@gmail.com",
                NormalizedEmail = "MATILDA@GMAIL.COM",
                EmailConfirmed = false,
                SecurityStamp = Guid.NewGuid().ToString(),
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                PhoneNumber = null,
                PhoneNumberConfirmed = false,
                TwoFactorEnabled = false,
                LockoutEnd = null,
                LockoutEnabled = true,
                AccessFailedCount = 0,
                PasswordHash = passwordHasher.HashPassword(null, "Admin123!")
            },
            new CustomUser
            {
                Id = "647cb00f-ba4e-4c48-87a2-d91cf9936b29",
                UserName = "hans@gmail.com",
                NormalizedUserName = "HANS@GMAIL.COM",
                Email = "hans@gmail.com",
                NormalizedEmail = "HANS@GMAIL.COM",
                EmailConfirmed = false,
                SecurityStamp = Guid.NewGuid().ToString(),
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                PhoneNumber = null,
                PhoneNumberConfirmed = false,
                TwoFactorEnabled = false,
                LockoutEnd = null,
                LockoutEnabled = true,
                AccessFailedCount = 0,
                PasswordHash = passwordHasher.HashPassword(null, "Admin123!")
            });
    }
}