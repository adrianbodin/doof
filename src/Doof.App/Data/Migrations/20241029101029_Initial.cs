using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Doof.App.Data.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    Discriminator = table.Column<string>(type: "TEXT", maxLength: 13, nullable: false),
                    UserName = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "INTEGER", nullable: false),
                    PasswordHash = table.Column<string>(type: "TEXT", nullable: true),
                    SecurityStamp = table.Column<string>(type: "TEXT", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "TEXT", nullable: true),
                    PhoneNumber = table.Column<string>(type: "TEXT", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "INTEGER", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "INTEGER", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "TEXT", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "INTEGER", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Ingredients",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ingredients", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tags",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UnicodeEmoji = table.Column<string>(type: "TEXT", maxLength: 9, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tags", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    RoleId = table.Column<string>(type: "TEXT", nullable: false),
                    ClaimType = table.Column<string>(type: "TEXT", nullable: true),
                    ClaimValue = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UserId = table.Column<string>(type: "TEXT", nullable: false),
                    ClaimType = table.Column<string>(type: "TEXT", nullable: true),
                    ClaimValue = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "TEXT", maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(type: "TEXT", maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "TEXT", nullable: true),
                    UserId = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "TEXT", nullable: false),
                    RoleId = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "TEXT", nullable: false),
                    LoginProvider = table.Column<string>(type: "TEXT", maxLength: 128, nullable: false),
                    Name = table.Column<string>(type: "TEXT", maxLength: 128, nullable: false),
                    Value = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Recipes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    AuthorId = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Recipes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Recipes_AspNetUsers_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "IngredientTranslations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    IngredientId = table.Column<int>(type: "INTEGER", nullable: false),
                    Language = table.Column<string>(type: "TEXT", maxLength: 10, nullable: false),
                    IngredientName = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IngredientTranslations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_IngredientTranslations_Ingredients_IngredientId",
                        column: x => x.IngredientId,
                        principalTable: "Ingredients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TagTranslations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    TagId = table.Column<int>(type: "INTEGER", nullable: false),
                    Language = table.Column<string>(type: "TEXT", maxLength: 10, nullable: false),
                    TagName = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TagTranslations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TagTranslations_Tags_TagId",
                        column: x => x.TagId,
                        principalTable: "Tags",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "IngredientRecipe",
                columns: table => new
                {
                    IngredientsId = table.Column<int>(type: "INTEGER", nullable: false),
                    RecipesId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IngredientRecipe", x => new { x.IngredientsId, x.RecipesId });
                    table.ForeignKey(
                        name: "FK_IngredientRecipe_Ingredients_IngredientsId",
                        column: x => x.IngredientsId,
                        principalTable: "Ingredients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_IngredientRecipe_Recipes_RecipesId",
                        column: x => x.RecipesId,
                        principalTable: "Recipes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RecipeImages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Url = table.Column<string>(type: "TEXT", nullable: false),
                    RecipeId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RecipeImages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RecipeImages_Recipes_RecipeId",
                        column: x => x.RecipeId,
                        principalTable: "Recipes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RecipeTag",
                columns: table => new
                {
                    RecipesId = table.Column<int>(type: "INTEGER", nullable: false),
                    TagsId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RecipeTag", x => new { x.RecipesId, x.TagsId });
                    table.ForeignKey(
                        name: "FK_RecipeTag_Recipes_RecipesId",
                        column: x => x.RecipesId,
                        principalTable: "Recipes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RecipeTag_Tags_TagsId",
                        column: x => x.TagsId,
                        principalTable: "Tags",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RecipeTranslations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    RecipeId = table.Column<int>(type: "INTEGER", nullable: false),
                    Language = table.Column<string>(type: "TEXT", maxLength: 10, nullable: false),
                    RecipeTitle = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    RecipeSubTitle = table.Column<string>(type: "TEXT", maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RecipeTranslations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RecipeTranslations_Recipes_RecipeId",
                        column: x => x.RecipeId,
                        principalTable: "Recipes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RecipeSteps",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    RecipeTranslationId = table.Column<int>(type: "INTEGER", nullable: false),
                    StepNumber = table.Column<int>(type: "INTEGER", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "TEXT", maxLength: 500, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RecipeSteps", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RecipeSteps_RecipeTranslations_RecipeTranslationId",
                        column: x => x.RecipeTranslationId,
                        principalTable: "RecipeTranslations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "0462034d-8221-4cb2-8a68-db22c1028c5f", 0, "b4223ba4-460e-4bab-9a6c-c20e6ad32b40", "CustomUser", "matilda@gmail.com", false, true, null, "MATILDA@GMAIL.COM", "MATILDA@GMAIL.COM", "AQAAAAIAAYagAAAAEPRN+2WhtFu8VJ/EXCje1RwKZdzys7S+HtnUhDcdwrzXP9H1m/5xnOo80aBTV543mQ==", null, false, "34301463-39b6-431f-be14-e85397baed88", false, "matilda@gmail.com" },
                    { "3243c86d-7438-48cb-9a75-7d9bff08b725", 0, "52018cb5-8c28-4290-a9fb-aab4e69c2e2b", "CustomUser", "adrian@gmail.com", true, true, null, "ADRIAN@GMAIL.COM", "ADRIAN@GMAIL.COM", "AQAAAAIAAYagAAAAEDeBWVDhWEZXWDnzhKYn5nr09eNXGzFmo8+XmyRacTfq0+gWEKhg/VByhAYW01g+BA==", null, false, "de7fee94-edc2-4cad-9dd3-5e60df8c8d27", false, "adrian@gmail.com" },
                    { "647cb00f-ba4e-4c48-87a2-d91cf9936b29", 0, "c842f0e4-9398-41b2-ad03-6df8d1c632c0", "CustomUser", "hans@gmail.com", false, true, null, "HANS@GMAIL.COM", "HANS@GMAIL.COM", "AQAAAAIAAYagAAAAENaI82MmFB6+69cUmWKZgGqe2Y1dhT8078qidKLNhrk8lLWY3/FZJIJgsEFAKt82+A==", null, false, "a0992680-fe92-4439-8659-d5d729a21d4b", false, "hans@gmail.com" }
                });

            migrationBuilder.InsertData(
                table: "Ingredients",
                column: "Id",
                values: new object[]
                {
                    1,
                    2
                });

            migrationBuilder.InsertData(
                table: "Tags",
                columns: new[] { "Id", "UnicodeEmoji" },
                values: new object[] { 1, "🍔" });

            migrationBuilder.InsertData(
                table: "IngredientTranslations",
                columns: new[] { "Id", "IngredientId", "IngredientName", "Language" },
                values: new object[,]
                {
                    { 1, 1, "Bread", "en-US" },
                    { 2, 1, "Bröd", "sv-SE" },
                    { 3, 1, "パン", "ja-JP" },
                    { 4, 1, "Pain", "fr-FR" },
                    { 5, 1, "Pan", "es-ES" },
                    { 6, 2, "Cheese", "en-US" },
                    { 7, 2, "Ost", "sv-SE" },
                    { 8, 2, "チーズ", "ja-JP" },
                    { 9, 2, "Fromage", "fr-FR" },
                    { 10, 2, "Queso", "es-ES" }
                });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Id", "AuthorId" },
                values: new object[,]
                {
                    { 1, "3243c86d-7438-48cb-9a75-7d9bff08b725" },
                    { 2, "0462034d-8221-4cb2-8a68-db22c1028c5f" },
                    { 3, "647cb00f-ba4e-4c48-87a2-d91cf9936b29" }
                });

            migrationBuilder.InsertData(
                table: "TagTranslations",
                columns: new[] { "Id", "Language", "TagId", "TagName" },
                values: new object[,]
                {
                    { 1, "en-US", 1, "Burger" },
                    { 2, "sv-SE", 1, "Hamburgare" },
                    { 3, "ja-JP", 1, "バーガー" },
                    { 4, "fr-FR", 1, "Hamburger" },
                    { 5, "es-ES", 1, "Hamburguesa" }
                });

            migrationBuilder.InsertData(
                table: "RecipeImages",
                columns: new[] { "Id", "RecipeId", "Url" },
                values: new object[,]
                {
                    { 1, 1, "https://doofstorage.blob.core.windows.net/recipes/1_1.jpg" },
                    { 2, 1, "https://doofstorage.blob.core.windows.net/recipes/1_2.jpg" },
                    { 3, 2, "https://doofstorage.blob.core.windows.net/recipes/2_1.jpg" },
                    { 4, 2, "https://doofstorage.blob.core.windows.net/recipes/2_2.jpg" },
                    { 5, 3, "https://doofstorage.blob.core.windows.net/recipes/3_1.jpg" },
                    { 6, 3, "https://doofstorage.blob.core.windows.net/recipes/3_2.jpg" }
                });

            migrationBuilder.InsertData(
                table: "RecipeTranslations",
                columns: new[] { "Id", "Language", "RecipeId", "RecipeSubTitle", "RecipeTitle" },
                values: new object[,]
                {
                    { 1, "en-US", 1, "The best pancakes in the world", "Pancakes" },
                    { 2, "sv-SE", 1, "Världens bästa pannkakor", "Pannkakor" },
                    { 3, "ja-JP", 1, "世界で最高のパンケーキ", "パンケーキ" },
                    { 4, "fr-FR", 1, "Les meilleures crêpes du monde", "Crêpes" },
                    { 5, "es-ES", 1, "Los mejores panqueques del mundo", "Panqueques" },
                    { 6, "en-US", 2, "The best meatballs in the world", "Meatballs" },
                    { 7, "sv-SE", 2, "Världens bästa köttbullar", "Köttbullar" },
                    { 8, "ja-JP", 2, "世界で最高のミートボール", "ミートボール" },
                    { 9, "fr-FR", 2, "Les meilleures boulettes de viande du monde", "Boulettes de viande" },
                    { 10, "es-ES", 2, "Las mejores albóndigas del mundo", "Albóndigas" },
                    { 11, "en-US", 3, "The best tacos in the world", "Tacos" },
                    { 12, "sv-SE", 3, "Världens bästa tacos", "Tacos" },
                    { 13, "ja-JP", 3, "世界で最高のタコス", "タコス" },
                    { 14, "fr-FR", 3, "Les meilleurs tacos du monde", "Tacos" },
                    { 15, "es-ES", 3, "Los mejores tacos del mundo", "Tacos" }
                });

            migrationBuilder.InsertData(
                table: "RecipeSteps",
                columns: new[] { "Id", "Description", "RecipeTranslationId", "StepNumber" },
                values: new object[,]
                {
                    { 1, "Mix the flour, sugar, baking powder, and salt in a bowl.", 1, 1 },
                    { 2, "Add the milk, egg, and melted butter to the dry ingredients.", 1, 2 },
                    { 3, "Mix until smooth.", 1, 3 },
                    { 4, "Heat a lightly oiled griddle or frying pan over medium-high heat.", 1, 4 },
                    { 5, "Pour or scoop the batter onto the griddle, using approximately 1/4 cup for each pancake.", 1, 5 },
                    { 6, "Brown on both sides and serve hot.", 1, 6 },
                    { 7, "Blanda mjöl, socker, bakpulver och salt i en skål.", 2, 1 },
                    { 8, "Tillsätt mjölk, ägg och smält smör till de torra ingredienserna.", 2, 2 },
                    { 9, "Blanda tills slät.", 2, 3 },
                    { 10, "Värm en lätt oljad stekpanna över medelhög värme.", 2, 4 },
                    { 11, "Häll eller skopa smeten på stekpannan, använd cirka 1/4 kopp för varje pannkaka.", 2, 5 },
                    { 12, "Bryn på båda sidor och servera varm.", 2, 6 },
                    { 13, "小麦粉、砂糖、ベーキングパウダー、塩をボウルに入れて混ぜます。", 3, 1 },
                    { 14, "牛乳、卵、溶かしバターを乾燥した材料に加えます。", 3, 2 },
                    { 15, "滑らかになるまで混ぜます。", 3, 3 },
                    { 16, "中火で軽くオイルを塗ったグリドルまたはフライパンを温めます。", 3, 4 },
                    { 17, "グリドルに生地を流し込み、各パンケーキに約1/4カップ使用します。", 3, 5 },
                    { 18, "両面を焼いて熱々で提供します。", 3, 6 },
                    { 19, "Mélanger la farine, le sucre, la levure chimique et le sel dans un bol.", 4, 1 },
                    { 20, "Ajouter le lait, l'œuf et le beurre fondu aux ingrédients secs.", 4, 2 },
                    { 21, "Mélanger jusqu'à obtenir une pâte lisse.", 4, 3 },
                    { 22, "Chauffer une poêle légèrement huilée à feu moyen-vif.", 4, 4 },
                    { 23, "Verser ou cuillère la pâte sur la poêle, en utilisant environ 1/4 de tasse pour chaque crêpe.", 4, 5 },
                    { 24, "Dorer des deux côtés et servir chaud.", 4, 6 },
                    { 25, "Mezclar la harina, el azúcar, el polvo de hornear y la sal en un tazón.", 5, 1 },
                    { 26, "Agregue la leche, el huevo y la mantequilla derretida a los ingredientes secos.", 5, 2 },
                    { 27, "Mezclar hasta que quede suave.", 5, 3 },
                    { 28, "Caliente una plancha ligeramente engrasada o una sartén a fuego medio-alto.", 5, 4 },
                    { 29, "Vierta o saque la masa en la plancha, usando aproximadamente 1/4 de taza para cada panqueque.", 5, 5 },
                    { 30, "Dore por ambos lados y sirva caliente.", 5, 6 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_IngredientRecipe_RecipesId",
                table: "IngredientRecipe",
                column: "RecipesId");

            migrationBuilder.CreateIndex(
                name: "IX_IngredientTranslations_IngredientId",
                table: "IngredientTranslations",
                column: "IngredientId");

            migrationBuilder.CreateIndex(
                name: "IX_RecipeImages_RecipeId",
                table: "RecipeImages",
                column: "RecipeId");

            migrationBuilder.CreateIndex(
                name: "IX_Recipes_AuthorId",
                table: "Recipes",
                column: "AuthorId");

            migrationBuilder.CreateIndex(
                name: "IX_RecipeSteps_RecipeTranslationId",
                table: "RecipeSteps",
                column: "RecipeTranslationId");

            migrationBuilder.CreateIndex(
                name: "IX_RecipeTag_TagsId",
                table: "RecipeTag",
                column: "TagsId");

            migrationBuilder.CreateIndex(
                name: "IX_RecipeTranslations_RecipeId",
                table: "RecipeTranslations",
                column: "RecipeId");

            migrationBuilder.CreateIndex(
                name: "IX_TagTranslations_TagId",
                table: "TagTranslations",
                column: "TagId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "IngredientRecipe");

            migrationBuilder.DropTable(
                name: "IngredientTranslations");

            migrationBuilder.DropTable(
                name: "RecipeImages");

            migrationBuilder.DropTable(
                name: "RecipeSteps");

            migrationBuilder.DropTable(
                name: "RecipeTag");

            migrationBuilder.DropTable(
                name: "TagTranslations");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Ingredients");

            migrationBuilder.DropTable(
                name: "RecipeTranslations");

            migrationBuilder.DropTable(
                name: "Tags");

            migrationBuilder.DropTable(
                name: "Recipes");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
