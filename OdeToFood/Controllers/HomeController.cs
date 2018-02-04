namespace OdeToFood.Controllers
{
    using Microsoft.AspNetCore.Mvc;

    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return Content($"Hi, from {nameof(HomeController)}");
        }
    }
}
