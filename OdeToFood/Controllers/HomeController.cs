namespace OdeToFood.Controllers
{
    using Microsoft.AspNetCore.Mvc;

    using OdeToFood.Models;

    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var model = new Restaurant
            {
                Id = 1,
                Name = "GM's"
            };

            return View(model);
        }
    }
}
