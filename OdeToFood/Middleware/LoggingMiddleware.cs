namespace OdeToFood.Middleware
{
    using System.Threading.Tasks;

    using Microsoft.AspNetCore.Http;

    public class LoggingMiddleware
    {
        private RequestDelegate _nextDelegate;

        public LoggingMiddleware(RequestDelegate next)
        {
            this._nextDelegate = next;
        }

        public async Task Invoke(HttpContext context)
        {
            await this._nextDelegate.Invoke(context);
        }
    }
}
