using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Doof.App.Features.Recipes;

public class Tag
{
    public int Id { get; set; }

    public required string UnicodeEmoji { get; set; }

    public ICollection<TagTranslation> Translations { get; set; } = [];

    public ICollection<Recipe> Recipes { get; set; } = [];

    public static void Configure(ModelBuilder builder)
    {
        builder.Entity<Tag>(t =>
        {
            t.HasKey(t => t.Id);

            t.Property(tt => tt.UnicodeEmoji).IsRequired().HasMaxLength(9);

            t.HasMany(tt => tt.Translations)
                .WithOne(tt => tt.Tag)
                .HasForeignKey(tt => tt.TagId);
        });
    }

    public static void Seed(ModelBuilder builder)
    {
        builder.Entity<Tag>().HasData(
            new Tag
            {
                Id = 1,
                UnicodeEmoji = "🍔"
            }
        );
    }
}