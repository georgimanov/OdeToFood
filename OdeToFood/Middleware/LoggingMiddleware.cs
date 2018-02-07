namespace OdeToFood.Middleware
{
    using System.Diagnostics;
    using System.Threading.Tasks;

    using Microsoft.AspNetCore.Http;

    public class LoggingMiddleware
    {
        private readonly RequestDelegate _nextDelegate;

        public LoggingMiddleware(RequestDelegate next)
        {
            this._nextDelegate = next;
        }

        public async Task Invoke(HttpContext context)
        {
            Debug.WriteLine($"{nameof(LoggingMiddleware)} invoked.");
            await this._nextDelegate.Invoke(context);
        }
    }
}
