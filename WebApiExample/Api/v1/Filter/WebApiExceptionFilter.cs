using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http.Filters;

namespace WebApiExample.Api.v1.Filter
{
    public class WebApiExceptionFilterAttribute : ExceptionFilterAttribute
    {
        public override void OnException(HttpActionExecutedContext context)
        {
            // Don't send out stack traces in production; this would be security vulnerability.
            context.Response = context.Request.CreateErrorResponse(HttpStatusCode.InternalServerError, context.Exception);
        }
    }
}