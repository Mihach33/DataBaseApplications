using Microsoft.AspNetCore.Http;
using System;
using System.IO;
using System.Threading.Tasks;

namespace WebApiExample.Middlewares
{
    public class ErrorLoggingMiddleware
    {
        private readonly RequestDelegate _next;

        public ErrorLoggingMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext httpContext)
        {
            try
            {
                await _next(httpContext);
            }
            catch (Exception exc)
            {
                StreamWriter sw = new StreamWriter("logs.txt", true);
                sw.WriteLine(exc.Message);
                sw.Close();
                httpContext.Response.StatusCode = 500;
                await httpContext.Response.WriteAsync("Unexpected problem!");
            }
        }

    }
}
