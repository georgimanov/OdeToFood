using OdeToFood.Services;

namespace OdeToFood.ViewComponents
{
    using Microsoft.AspNetCore.Mvc;

    public class GreeterViewComponent : ViewComponent
    {
        private readonly IGreeter _greeter;

        public GreeterViewComponent(IGreeter greeter)
        {
            _greeter = greeter;
        }

        public IViewComponentResult Invoke()
        {
            var model = _greeter.GetGreeting();

            return View("Default", model);
        }
    }
}
