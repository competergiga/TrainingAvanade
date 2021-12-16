using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using System.Globalization;
using System.Threading.Tasks;

namespace Training.WebAPI.Helpers
{
    //public class RequestCultureMiddleware
    //{

    //    private readonly RequestDelegate _next;


    //    public RequestCultureMiddleware(RequestDelegate next)
    //    {
    //        _next = next;
    //    }


    //    public async Task InvokeAsync(HttpContext context) 
    //    {
    //        var cultureQuery = context.Request.Query["culture"];

    //        if (!string.IsNullOrEmpty(cultureQuery)) 
    //        {
    //            CultureInfo.CurrentCulture = new CultureInfo(cultureQuery);
    //            CultureInfo.CurrentUICulture = new CultureInfo(cultureQuery);
    //        }

    //        await _next(context);
    //    }
    //}


    public class RequestCultureMiddleware : IMiddleware
    {

        // private readonly ILogger<RequestCultureMiddleware> _logger;
        ILogger _logger;

        public RequestCultureMiddleware(ILogger<RequestCultureMiddleware> logger)
        {
            _logger = logger;
        }

        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {

            // Podemos pasar datos así https://localhost:44303/api/book?culture=es-ES
            var cultureQuery = context.Request.Query["culture"];

            if (!string.IsNullOrEmpty(cultureQuery))
            {
                CultureInfo.CurrentCulture = new CultureInfo(cultureQuery);
                CultureInfo.CurrentUICulture = new CultureInfo(cultureQuery);
            }


            _logger.LogInformation("RequestCultureMiddleware usuario -> " + context.User.Identity.Name);
             
            await next(context);
        }

    }
}
