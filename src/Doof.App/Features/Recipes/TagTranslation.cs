using Microsoft.EntityFrameworkCore;

namespace Doof.App.Features.Recipes;

public class TagTranslation
{
    public int Id { get; set; }

    public int TagId { get; set; }
    public Tag Tag { get; set; } = null!;

    public required string Language { get; set; }

    public required string TagName { get; set; }

    public static void Configure(ModelBuilder builder)
    {
        builder.Entity<TagTranslation>(e =>
        {
            e.HasKey(tt => tt.Id);
            e.Property(tt => tt.Language).IsRequired().HasMaxLength(10);
            e.Property(tt => tt.TagName).IsRequired().HasMaxLength(50);
            e.HasOne(tt => tt.Tag)
                .WithMany(i => i.Translations)
                .HasForeignKey(it => it.TagId);
        });
    }

    public static void Seed(ModelBuilder builder)
    {
        builder.Entity<TagTranslation>().HasData(
            new TagTranslation
            {
                Id = 1,
                TagId = 1,
                Language = "en-US",
                TagName = "Burger"
            },
            new TagTranslation
            {
                Id = 2,
                TagId = 1,
                Language = "sv-SE",
                TagName = "Hamburgare"
            },
            new TagTranslation
            {
                Id = 3,
                TagId = 1,
                Language = "ja-JP",
                TagName = "バーガー"
            },
            new TagTranslation
            {
                Id = 4,
                TagId = 1,
                Language = "fr-FR",
                TagName = "Hamburger"
            },
            new TagTranslation
            {
                Id = 5,
                TagId = 1,
                Language = "es-ES",
                TagName = "Hamburguesa"
            }
        );
    }
}