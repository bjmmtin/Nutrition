using Nutrition.Models;

namespace Nutrition.Controllers
{
    public interface INutritionService
    {
        NutritionLabel GetNutritionData(string query);
    }
    public class NutritionService : INutritionService
    {
        public NutritionLabel GetNutritionData(string query)
        {
            // Stubbed response for demonstration
            // In a real application, you might fetch this data from a database or an external API
            return new NutritionLabel
            {
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
            };
        }
    }
}
