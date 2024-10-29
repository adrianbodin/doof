using Microsoft.EntityFrameworkCore;

namespace Doof.App.Features.Recipes;

public class RecipeImage
{
    public int Id { get; set; }
    public required string Url { get; set; }
    public int RecipeId { get; set; }
    public Recipe Recipe { get; set; } = null!;

    public static void Configure(ModelBuilder builder)
    {
        builder.Entity<RecipeImage>(e =>
        {
            e.HasKey(ri => ri.Id);
        });
    }

    public static void Seed(ModelBuilder builder)
    {
        builder.Entity<RecipeImage>().HasData(
            new RecipeImage
            {
                Id = 1,
                Url = "https://doofstorage.blob.core.windows.net/recipes/1_1.jpg",
                RecipeId = 1
            },
            new RecipeImage
            {
                Id = 2,
                Url = "https://doofstorage.blob.core.windows.net/recipes/1_2.jpg",
                RecipeId = 1
            },
            new RecipeImage
            {
                Id = 3,
                Url = "https://doofstorage.blob.core.windows.net/recipes/2_1.jpg",
                RecipeId = 2
            },
            new RecipeImage
            {
                Id = 4,
                Url = "https://doofstorage.blob.core.windows.net/recipes/2_2.jpg",
                RecipeId = 2
            },
            new RecipeImage
            {
                Id = 5,
                Url = "https://doofstorage.blob.core.windows.net/recipes/3_1.jpg",
                RecipeId = 3
            },
            new RecipeImage
            {
                Id = 6,
                Url = "https://doofstorage.blob.core.windows.net/recipes/3_2.jpg",
                RecipeId = 3
            }
        );
    }
}