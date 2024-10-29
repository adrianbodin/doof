using Microsoft.EntityFrameworkCore;

namespace Doof.App.Features.Recipes;

public class RecipeStep
{
    public int Id { get; set; }

    public int RecipeTranslationId { get; set; }
    public RecipeTranslation RecipeTranslation { get; set; } = null!;

    public required int StepNumber { get; set; }

    public required string Description { get; set; }

    public static void Configure(ModelBuilder builder)
    {
        builder.Entity<RecipeStep>(e =>
        {
            e.HasKey(rs => rs.Id);
            e.Property(rs => rs.Description).HasMaxLength(500).IsRequired();
            e.Property(rs => rs.StepNumber).HasMaxLength(50).IsRequired();
            e.HasOne(rs => rs.RecipeTranslation)
                .WithMany(rt => rt.Steps)
                .HasForeignKey(rs => rs.RecipeTranslationId);
        });
    }

    public static void Seed(ModelBuilder builder)
    {
        builder.Entity<RecipeStep>().HasData(
            new RecipeStep
            {
                Id = 1,
                RecipeTranslationId = 1,
                StepNumber = 1,
                Description = "Mix the flour, sugar, baking powder, and salt in a bowl."
            },
            new RecipeStep
            {
                Id = 2,
                RecipeTranslationId = 1,
                StepNumber = 2,
                Description = "Add the milk, egg, and melted butter to the dry ingredients."
            },
            new RecipeStep
            {
                Id = 3,
                RecipeTranslationId = 1,
                StepNumber = 3,
                Description = "Mix until smooth."
            },
            new RecipeStep
            {
                Id = 4,
                RecipeTranslationId = 1,
                StepNumber = 4,
                Description = "Heat a lightly oiled griddle or frying pan over medium-high heat."
            },
            new RecipeStep
            {
                Id = 5,
                RecipeTranslationId = 1,
                StepNumber = 5,
                Description = "Pour or scoop the batter onto the griddle, using approximately 1/4 cup for each pancake."
            },
            new RecipeStep
            {
                Id = 6,
                RecipeTranslationId = 1,
                StepNumber = 6,
                Description = "Brown on both sides and serve hot."
            },
            new RecipeStep
            {
                Id = 7,
                RecipeTranslationId = 2,
                StepNumber = 1,
                Description = "Blanda mjöl, socker, bakpulver och salt i en skål."
            },
            new RecipeStep
            {
                Id = 8,
                RecipeTranslationId = 2,
                StepNumber = 2,
                Description = "Tillsätt mjölk, ägg och smält smör till de torra ingredienserna."
            },
            new RecipeStep
            {
                Id = 9,
                RecipeTranslationId = 2,
                StepNumber = 3,
                Description = "Blanda tills slät."
            },
            new RecipeStep
            {
                Id = 10,
                RecipeTranslationId = 2,
                StepNumber = 4,
                Description = "Värm en lätt oljad stekpanna över medelhög värme."

            },
            new RecipeStep
            {
                Id = 11,
                RecipeTranslationId = 2,
                StepNumber = 5,
                Description = "Häll eller skopa smeten på stekpannan, använd cirka 1/4 kopp för varje pannkaka."
            },
            new RecipeStep
            {
                Id = 12,
                RecipeTranslationId = 2,
                StepNumber = 6,
                Description = "Bryn på båda sidor och servera varm."
            },
            new RecipeStep
            {
                Id = 13,
                RecipeTranslationId = 3,
                StepNumber = 1,
                Description = "小麦粉、砂糖、ベーキングパウダー、塩をボウルに入れて混ぜます。"
            },
            new RecipeStep
            {
                Id = 14,
                RecipeTranslationId = 3,
                StepNumber = 2,
                Description = "牛乳、卵、溶かしバターを乾燥した材料に加えます。"
            },
            new RecipeStep
            {
                Id = 15,
                RecipeTranslationId = 3,
                StepNumber = 3,
                Description = "滑らかになるまで混ぜます。"
            },
            new RecipeStep
            {
                Id = 16,
                RecipeTranslationId = 3,
                StepNumber = 4,
                Description = "中火で軽くオイルを塗ったグリドルまたはフライパンを温めます。"
            },
            new RecipeStep
            {
                Id = 17,
                RecipeTranslationId = 3,
                StepNumber = 5,
                Description = "グリドルに生地を流し込み、各パンケーキに約1/4カップ使用します。"
            },
            new RecipeStep
            {
                Id = 18,
                RecipeTranslationId = 3,
                StepNumber = 6,
                Description = "両面を焼いて熱々で提供します。"
            },
            new RecipeStep
            {
                Id = 19,
                RecipeTranslationId = 4,
                StepNumber = 1,
                Description = "Mélanger la farine, le sucre, la levure chimique et le sel dans un bol."
            },
            new RecipeStep
            {
                Id = 20,
                RecipeTranslationId = 4,
                StepNumber = 2,
                Description = "Ajouter le lait, l'œuf et le beurre fondu aux ingrédients secs."
            },
            new RecipeStep
            {
                Id = 21,
                RecipeTranslationId = 4,
                StepNumber = 3,
                Description = "Mélanger jusqu'à obtenir une pâte lisse."
            },
            new RecipeStep
            {
                Id = 22,
                RecipeTranslationId = 4,
                StepNumber = 4,
                Description = "Chauffer une poêle légèrement huilée à feu moyen-vif."
            },
            new RecipeStep
            {
                Id = 23,
                RecipeTranslationId = 4,
                StepNumber = 5,
                Description =
                    "Verser ou cuillère la pâte sur la poêle, en utilisant environ 1/4 de tasse pour chaque crêpe."
            },
            new RecipeStep
            {
                Id = 24,
                RecipeTranslationId = 4,
                StepNumber = 6,
                Description = "Dorer des deux côtés et servir chaud."
            },
            new RecipeStep
            {
                Id = 25,
                RecipeTranslationId = 5,
                StepNumber = 1,
                Description = "Mezclar la harina, el azúcar, el polvo de hornear y la sal en un tazón."
            },
            new RecipeStep
            {
                Id = 26,
                RecipeTranslationId = 5,
                StepNumber = 2,
                Description = "Agregue la leche, el huevo y la mantequilla derretida a los ingredientes secos."
            },
            new RecipeStep
            {
                Id = 27,
                RecipeTranslationId = 5,
                StepNumber = 3,
                Description = "Mezclar hasta que quede suave."
            },
            new RecipeStep
            {
                Id = 28,
                RecipeTranslationId = 5,
                StepNumber = 4,
                Description = "Caliente una plancha ligeramente engrasada o una sartén a fuego medio-alto."
            },
            new RecipeStep
            {
                Id = 29,
                RecipeTranslationId = 5,
                StepNumber = 5,
                Description =
                    "Vierta o saque la masa en la plancha, usando aproximadamente 1/4 de taza para cada panqueque."
            },
            new RecipeStep
            {
                Id = 30,
                RecipeTranslationId = 5,
                StepNumber = 6,
                Description = "Dore por ambos lados y sirva caliente."
            });
        //Todo This is only for the first recipe, add more if needed for development
    }
}