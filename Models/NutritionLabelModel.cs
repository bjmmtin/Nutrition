namespace Nutrition.Models
{
    public class NutritionLabel
    {
 
        public int Id { get; set; }
        public string? FoodName { get; set; }
        public string? ServingSize { get; set; }
        public int Calories { get; set; }
        public int TotalFat { get; set; }
        public int SaturatedFat { get; set; }
        public int TransFat { get; set; }
        public int Cholesterol { get; set; }
        public int Sodium { get; set; }
        public int TotalCarbohydrates { get; set; }
        public int DietaryFiber { get; set; }
        public int Sugars { get; set; }
        public int Protein { get; set; }
        public int VitaminA { get; set; }
        public int VitaminC { get; set; }
        public int Calcium { get; set; }
        public int Iron { get; set; }
    }
}
