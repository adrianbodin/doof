﻿using Microsoft.EntityFrameworkCore;

namespace doof.Features.Recipes;

public class TagTranslation
{
    public int Id { get; set; }

    public int TagId { get; set; }
    public Tag Tag { get; set; } = null!;

    public required string Language { get; set; }

    public required string TagName { get; set; }

    public required string Utf8Value { get; set; }

    public static void Configure(ModelBuilder builder)
    {
        builder.Entity<TagTranslation>(e =>
        {
            e.HasKey(tt => tt.Id);
            e.Property(tt => tt.Language).IsRequired().HasMaxLength(10);
            e.Property(tt => tt.TagName).IsRequired().HasMaxLength(50);
            e.Property(tt => tt.Utf8Value).IsRequired().HasMaxLength(9);
            e.HasOne(tt => tt.Tag)
                .WithMany(i => i.Translations)
                .HasForeignKey(it => it.TagId);
        });
    }
}