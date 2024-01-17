using Microsoft.AspNetCore.Mvc;

namespace WebAPICore.Controllers {
    [Route("api/[controller]")]
    [ApiController]
    public class SmartController : ControllerBase {
        [HttpGet("get_dishes")]
        public string[] GetDishes() {
            string[] result = { "Chicken", "Salad", "Veg" };
            return result;
        }
        [HttpGet("get_drinks")]
        public string[] GetDrinks() {
            string[] result = { "Chicken", "Salad", "Veg" };
            return result;
        }
        [HttpGet("get_drink/{id}")]
        public string[] GetDrink(int id) {
            string[] result = { "Chicken", "Salad", "Veg" };
            return result;
        }
    }
}