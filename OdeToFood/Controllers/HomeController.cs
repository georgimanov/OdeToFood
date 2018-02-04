namespace OdeToFood.Controllers
{
    using Microsoft.AspNetCore.Mvc;

    using OdeToFood.Models;
    using OdeToFood.Services;

    public class HomeController : Controller
    {
        private readonly IRestaurantData _restaurantData;

        public HomeController(IRestaurantData restaurantData)
        {
            _restaurantData = restaurantData;
        }

        public IActionResult Index()
        {
            var model = _restaurantData.GetAll();

            return View(model);
        }
    }
}
