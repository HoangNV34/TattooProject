using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Middleware
{
    public class MyMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ILogger _logger;

        public MyMiddleware(RequestDelegate next, ILoggerFactory loggerFactory)
        {
            _next = next;
            _logger = loggerFactory.CreateLogger("MyMiddleware");
        }

        public Task Invoke(HttpContext httpContext)
        {
            _logger.LogInformation("MyMiddleware executing..");
            return _next(httpContext);
        }
    }

    public static class MyMiddlewareExtensions
    {
        // extention method used to add the middleware to the Http request pipeline
        public static IApplicationBuilder UseMyMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<MyMiddleware>();
        }
    }
}
