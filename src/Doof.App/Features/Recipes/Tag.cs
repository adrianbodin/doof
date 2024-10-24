using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Doof.App.Features.Recipes;

public class Tag
{
    public int Id { get; set; }

    public ICollection<TagTranslation> Translations { get; set; } = [];

    public static void Configure(ModelBuilder builder)
    {
        builder.Entity<Tag>(e =>
        {
            e.HasKey(t => t.Id);
        });
    }
}