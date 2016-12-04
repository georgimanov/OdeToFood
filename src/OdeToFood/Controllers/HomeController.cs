using Microsoft.AspNetCore.Mvc;

using OdeToFood.Services;

namespace OdeToFood.Controllers
{
    public class HomeController : Controller
    {
        IRestaurantData _restaurantData;

        public HomeController(IRestaurantData restaurantData)
        {
            _restaurantData = restaurantData;
        }

        public ViewResult Index()
        {
            var model = _restaurantData.GetAll();

            return View(model);
        }
    }
}
