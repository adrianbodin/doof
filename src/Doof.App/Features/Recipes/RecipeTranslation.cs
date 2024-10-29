using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Doof.App.Features.Recipes;

public class RecipeTranslation
{
    public int Id { get; set; }

    public int RecipeId { get; set; }
    public Recipe Recipe { get; set; } = null!;

    //todo use enum or static class for language?
    public required string Language { get; set; }

    public required string RecipeTitle { get; set; }

    public string? RecipeSubTitle { get; set; }

    public ICollection<RecipeStep> Steps { get; set; } = [];

    public static void Configure(ModelBuilder builder)
    {
        builder.Entity<RecipeTranslation>(e =>
        {
            e.HasKey(rt => rt.Id);

            e.Property(r => r.Language).HasMaxLength(10);
            e.Property(r => r.RecipeTitle).HasMaxLength(50);
            e.Property(r => r.RecipeSubTitle).HasMaxLength(200);
        });
    }

    public static void Seed(ModelBuilder builder)
    {
        builder.Entity<RecipeTranslation>().HasData(
            new RecipeTranslation
            {
                Id = 1,
                RecipeId = 1,
                Language = "en-US",
                RecipeTitle = "Pancakes",
                RecipeSubTitle = "The best pancakes in the world"
            },
            new RecipeTranslation
            {
                Id = 2,
                RecipeId = 1,
                Language = "sv-SE",
                RecipeTitle = "Pannkakor",
                RecipeSubTitle = "Världens bästa pannkakor"
            },
            new RecipeTranslation
            {
                Id = 3,
                RecipeId = 1,
                Language = "ja-JP",
                RecipeTitle = "パンケーキ",
                RecipeSubTitle = "世界で最高のパンケーキ"
            },
            new RecipeTranslation
            {
                Id = 4,
                RecipeId = 1,
                Language = "fr-FR",
                RecipeTitle = "Crêpes",
                RecipeSubTitle = "Les meilleures crêpes du monde"
            },
            new RecipeTranslation
            {
                Id = 5,
                RecipeId = 1,
                Language = "es-ES",
                RecipeTitle = "Panqueques",
                RecipeSubTitle = "Los mejores panqueques del mundo"
            },
            new RecipeTranslation
            {
                Id = 6,
                RecipeId = 2,
                Language = "en-US",
                RecipeTitle = "Meatballs",
                RecipeSubTitle = "The best meatballs in the world"
            },
            new RecipeTranslation
            {
                Id = 7,
                RecipeId = 2,
                Language = "sv-SE",
                RecipeTitle = "Köttbullar",
                RecipeSubTitle = "Världens bästa köttbullar"
            },
            new RecipeTranslation
            {
                Id = 8,
                RecipeId = 2,
                Language = "ja-JP",
                RecipeTitle = "ミートボール",
                RecipeSubTitle = "世界で最高のミートボール"
            },
            new RecipeTranslation
            {
                Id = 9,
                RecipeId = 2,
                Language = "fr-FR",
                RecipeTitle = "Boulettes de viande",
                RecipeSubTitle = "Les meilleures boulettes de viande du monde"
            },
            new RecipeTranslation
            {
                Id = 10,
                RecipeId = 2,
                Language = "es-ES",
                RecipeTitle = "Albóndigas",
                RecipeSubTitle = "Las mejores albóndigas del mundo"
            },
            new RecipeTranslation
            {
                Id = 11,
                RecipeId = 3,
                Language = "en-US",
                RecipeTitle = "Tacos",
                RecipeSubTitle = "The best tacos in the world"
            },
            new RecipeTranslation
            {
                Id = 12,
                RecipeId = 3,
                Language = "sv-SE",
                RecipeTitle = "Tacos",
                RecipeSubTitle = "Världens bästa tacos"
            },
            new RecipeTranslation
            {
                Id = 13,
                RecipeId = 3,
                Language = "ja-JP",
                RecipeTitle = "タコス",
                RecipeSubTitle = "世界で最高のタコス"
            },
            new RecipeTranslation
            {
                Id = 14,
                RecipeId = 3,
                Language = "fr-FR",
                RecipeTitle = "Tacos",
                RecipeSubTitle = "Les meilleurs tacos du monde"
            },
            new RecipeTranslation
            {
                Id = 15,
                RecipeId = 3,
                Language = "es-ES",
                RecipeTitle = "Tacos",
                RecipeSubTitle = "Los mejores tacos del mundo"
            }
        );
    }
}