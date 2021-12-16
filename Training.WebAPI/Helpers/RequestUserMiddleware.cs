using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using System.Globalization;
using System.Threading.Tasks;

namespace Training.WebAPI.Helpers
{

    


        public class RequestUserMiddleware : IMiddleware
        {

            // private readonly ILogger<RequestCultureMiddleware> _logger;
            ILogger _logger;

            public RequestUserMiddleware(ILogger<RequestUserMiddleware> logger)
            {
                _logger = logger;
            }

            public async Task InvokeAsync(HttpContext context, RequestDelegate next)
            {


                _logger.LogInformation("RequestUserMiddleware -> " + context.User.Identity.Name);

                await next(context);
            }

        }
    }


