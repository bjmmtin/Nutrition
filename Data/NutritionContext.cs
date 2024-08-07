using Microsoft.EntityFrameworkCore;
using Nutrition.Models;

namespace Nutrition.Data
{
    public class NutritionContext : DbContext
    {
        public NutritionContext(DbContextOptions<NutritionContext> options) : base(options) { }
        public DbSet<NutritionLabel> NutritionLabels => Set<NutritionLabel>();
        public static void Seed(NutritionContext context)
        {
            if (!context.NutritionLabels.Any())
            {
                context.NutritionLabels.AddRange(
                    new NutritionLabel {
                        Id = 1,
                        FoodName = "Cheese",
                        ServingSize = "1 cup (228g)",
                        Calories = 200,
                        TotalFat = 8,
                        SaturatedFat = 1,
                        TransFat = 0,
                        Cholesterol = 30,
                        Sodium = 200,
                        TotalCarbohydrates = 30,
                        DietaryFiber = 5,
                        Sugars = 10,
                        Protein = 5,
                        VitaminA = 4,
                        VitaminC = 2,
                        Calcium = 20,
                        Iron = 4,
                    },
                    new NutritionLabel {
                        Id = 2,
                        FoodName = "Butter",
                        ServingSize = "1 cup (228g)",
                        Calories = 200,
                        TotalFat = 8,
                        SaturatedFat = 1,
                        TransFat = 0,
                        Cholesterol = 30,
                        Sodium = 200,
                        TotalCarbohydrates = 30,
                        DietaryFiber = 5,
                        Sugars = 10,
                        Protein = 5,
                        VitaminA = 4,
                        VitaminC = 2,
                        Calcium = 20,
                        Iron = 4,
                    }
                );
                context.SaveChanges();
            }
        }

    }

}
