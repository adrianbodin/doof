using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Doof.App.Features.Recipes;

public class Ingredient
{
    public int Id { get; set; }

    public ICollection<IngredientTranslation> Translations { get; set; } = [];

    public ICollection<Recipe> Recipes { get; set; } = [];

    public static void Configure(ModelBuilder builder)
    {
        builder.Entity<Ingredient>(e =>
        {
            e.HasKey(i => i.Id);
        });
    }

    public static void Seed(ModelBuilder builder)
    {
        builder.Entity<Ingredient>().HasData(
            new Ingredient
            {
                Id = 1
            },
            new Ingredient
            {
                Id = 2
            }
        );
    }
}