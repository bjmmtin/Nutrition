using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Nutrition.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "NutritionLabels",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FoodName = table.Column<string>(type: "TEXT", nullable: true),
                    ServingSize = table.Column<string>(type: "TEXT", nullable: true),
                    Calories = table.Column<int>(type: "INTEGER", nullable: false),
                    TotalFat = table.Column<int>(type: "INTEGER", nullable: false),
                    SaturatedFat = table.Column<int>(type: "INTEGER", nullable: false),
                    TransFat = table.Column<int>(type: "INTEGER", nullable: false),
                    Cholesterol = table.Column<int>(type: "INTEGER", nullable: false),
                    Sodium = table.Column<int>(type: "INTEGER", nullable: false),
                    TotalCarbohydrates = table.Column<int>(type: "INTEGER", nullable: false),
                    DietaryFiber = table.Column<int>(type: "INTEGER", nullable: false),
                    Sugars = table.Column<int>(type: "INTEGER", nullable: false),
                    Protein = table.Column<int>(type: "INTEGER", nullable: false),
                    VitaminA = table.Column<int>(type: "INTEGER", nullable: false),
                    VitaminC = table.Column<int>(type: "INTEGER", nullable: false),
                    Calcium = table.Column<int>(type: "INTEGER", nullable: false),
                    Iron = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NutritionLabels", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "NutritionLabels");
        }
    }
}
