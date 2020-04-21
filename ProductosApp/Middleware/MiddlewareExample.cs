using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductosApp.Middleware
{
    public class MiddlewareExample
    {

        private readonly RequestDelegate _next;

        public MiddlewareExample (RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            try
            {
                await _next.Invoke(context);
                await context.Response.WriteAsync(DateTime.Now.ToString());

            }catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
