using Microsoft.EntityFrameworkCore;

namespace Nutrition.Data
{
    public static class DataExtensions
    {
        public static void MigrateDb(this WebApplication app)
        {
            using var scope = app.Services.CreateScope();
            var Dbcontext = scope.ServiceProvider.GetRequiredService<NutritionContext>();
            Dbcontext.Database.Migrate();
            NutritionContext.Seed(Dbcontext);
        }
    }
}
