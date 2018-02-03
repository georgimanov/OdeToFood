namespace OdeToFood
{
    using Microsoft.Extensions.Configuration;

    internal class Greeter : IGreeter
    {
        private readonly IConfiguration _configuration;

        public Greeter(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public string GetGreeting()
        {
            return _configuration["Greeting"];
        }
    }
}