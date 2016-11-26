using Microsoft.AspNetCore.Mvc;

namespace OdeToFood.Controllers
{
    [Route("[controller]")]
    public class AboutController
    {
        [Route("")]
        public string Phone()
        {
            return "+1 4544";
        }

        [Route("action")]
        public string Country()
        {
            return "BG";
        }
    }
}
