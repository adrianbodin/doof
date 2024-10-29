using Microsoft.EntityFrameworkCore;

namespace Doof.App.Features.Recipes;

public class IngredientTranslation
{
    public int Id { get; set; }

    public int IngredientId { get; set; }
    public Ingredient Ingredient { get; set; } = null!;

    public required string Language { get; set; }

    public required string IngredientName { get; set; }

    public static void Configure(ModelBuilder builder)
    {
        builder.Entity<IngredientTranslation>(e =>
        {
            e.HasKey(it => it.Id);
            e.Property(it => it.Language).IsRequired().HasMaxLength(10);
            e.Property(it => it.IngredientName).IsRequired().HasMaxLength(50);
            e.HasOne(it => it.Ingredient)
                .WithMany(i => i.Translations)
                .HasForeignKey(it => it.IngredientId);
        });
    }

    public static void Seed(ModelBuilder builder)
    {
        builder.Entity<IngredientTranslation>().HasData(
            new IngredientTranslation
            {
                Id = 1,
                IngredientId = 1,
                Language = "en-US",
                IngredientName = "Bread"
            },
            new IngredientTranslation
            {
                Id = 2,
                IngredientId = 1,
                Language = "sv-SE",
                IngredientName = "Bröd"
            },
            new IngredientTranslation
            {
                Id = 3,
                IngredientId = 1,
                Language = "ja-JP",
                IngredientName = "パン"
            },
            new IngredientTranslation
            {
                Id = 4,
                IngredientId = 1,
                Language = "fr-FR",
                IngredientName = "Pain"
            },
            new IngredientTranslation
            {
                Id = 5,
                IngredientId = 1,
                Language = "es-ES",
                IngredientName = "Pan"
            },
            new IngredientTranslation
            {
                Id = 6,
                IngredientId = 2,
                Language = "en-US",
                IngredientName = "Cheese"
            },
            new IngredientTranslation
            {
                Id = 7,
                IngredientId = 2,
                Language = "sv-SE",
                IngredientName = "Ost"
            },
            new IngredientTranslation
            {
                Id = 8,
                IngredientId = 2,
                Language = "ja-JP",
                IngredientName = "チーズ"
            },
            new IngredientTranslation
            {
                Id = 9,
                IngredientId = 2,
                Language = "fr-FR",
                IngredientName = "Fromage"
            },
            new IngredientTranslation
            {
                Id = 10,
                IngredientId = 2,
                Language = "es-ES",
                IngredientName = "Queso"
            }
        );
    }
}