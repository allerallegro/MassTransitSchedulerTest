using Microsoft.AspNetCore.Http;
using System.Threading;
using System.Threading.Tasks;

namespace MassTransitSchedulerTest.Middleware
{
    public class RequestLoggingMiddleware
    {


        private readonly RequestDelegate _next;

        public RequestLoggingMiddleware(RequestDelegate next)
        {
            _next = next;
        }


        public async Task Invoke(HttpContext httpContext, CancellationToken ct)
        {
            try
            {
                await _next(httpContext);

            }
            catch (System.Exception)
            {

                throw;
            }

        }

    }
}
