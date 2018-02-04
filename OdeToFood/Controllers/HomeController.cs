namespace OdeToFood.Controllers
{
    using Microsoft.AspNetCore.Mvc;

    using OdeToFood.Services;
    using OdeToFood.ViewModels;

    public class HomeController : Controller
    {
        private readonly IRestaurantData _restaurantData;
        private readonly IGreeter _greeter;

        public HomeController(IRestaurantData restaurantData, IGreeter greeter)
        {
            _restaurantData = restaurantData;
            _greeter = greeter;
        }

        public IActionResult Index()
        {
            var model = new HomeIndexViewModel
            {
                Restaurants = _restaurantData.GetAll(),
                CurrentMessage = _greeter.GetGreeting()
            };

            return View(model);
        }
    }
}
