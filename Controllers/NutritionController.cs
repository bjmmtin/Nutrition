using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Nutrition.Data;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Nutrition.Controllers
{
    
    [Route("api/[controller]")]
    [ApiController]
    public class NutritionController : Controller
    {
        private readonly NutritionContext _context;

        public NutritionController(NutritionContext context)
        {
            _context = context;
            _nutritionService = new NutritionService();
        }
        private readonly NutritionService _nutritionService;

        [HttpGet]
        public IActionResult Get(string food)
        {

            // get from SQLite Database

            /*            var nutritionData = _context.NutritionLabels
                        .FirstOrDefault(n => n.FoodName.Equals(food, StringComparison.OrdinalIgnoreCase));*/
            var nutritionData = _context.NutritionLabels
                        .Where(n => EF.Functions.Like(n.FoodName, food))
                        .ToListAsync();
            if (nutritionData.Result.Count == 0)
            {
                return NotFound("Not found. This food isn't in the Database.\n Input another food");
            }

            return PartialView("_NutritionLabel", nutritionData.Result[0]);
            /*            var nutritionData = _nutritionService.GetNutritionData(food);
                        return PartialView("_NutritionLabel", nutritionData);*/
        }
        // GET api/<NutritionController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<NutritionController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<NutritionController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<NutritionController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
