using System.Collections.Generic;
using Doof.App.Features.Users;
using Microsoft.EntityFrameworkCore;

namespace Doof.App.Features.Recipes;

public class Recipe
{
    public int Id { get; set; }

    public required string AuthorId { get; set; }
    public CustomUser CustomUser { get; set; } = null!;

    public ICollection<RecipeImage> Images { get; set; } = [];

    public ICollection<RecipeTranslation> Translations { get; set; } = [];

    public ICollection<Ingredient> Ingredients { get; set; } = [];

    public ICollection<Tag> Tags { get; set; } = [];

    public static void Configure(ModelBuilder builder)
    {
        builder.Entity<Recipe>(e =>
        {
            e.HasKey(r => r.Id);

            e.Property(r => r.AuthorId).IsRequired();

            e.HasMany(r => r.Translations)
                .WithOne(r => r.Recipe)
                .HasForeignKey(r => r.RecipeId);

            e.HasMany(r => r.Images)
                .WithOne(ri => ri.Recipe)
                .HasForeignKey(ri => ri.RecipeId);

            e.HasOne(r => r.CustomUser)
                .WithMany(u => u.Recipes)
                .HasForeignKey(r => r.AuthorId);

            e.HasMany(r => r.Tags)
                .WithMany(r => r.Recipes);
        });
    }

    public static void Seed(ModelBuilder builder)
    {
        builder.Entity<Recipe>().HasData(
            new Recipe
            {
                Id = 1,
                AuthorId = "3243c86d-7438-48cb-9a75-7d9bff08b725"
            },
            new Recipe
            {
                Id = 2,
                AuthorId = "0462034d-8221-4cb2-8a68-db22c1028c5f"

            },
            new Recipe
            {
                Id = 3,
                AuthorId = "647cb00f-ba4e-4c48-87a2-d91cf9936b29"
            });
    }
}