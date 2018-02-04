namespace OdeToFood.Controllers
{
    public class HomeController
    {
        public string Index()
        {
            return $"Hi, from {nameof(HomeController)}";
        }
    }
}
