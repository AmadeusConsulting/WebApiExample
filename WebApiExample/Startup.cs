using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Owin;
using Owin;
using System.Web.Mvc;
using System.Web.Http;
using System.Web.Routing;
using System.Web.Optimization;
using System.Web.Http.ExceptionHandling;
using WebApiExample.Api.v1.Configuration;

[assembly: OwinStartup(typeof(WebApiExample.Startup))]

namespace WebApiExample
{
    public partial class Startup
    {
        // Allows Help Pages to crawl the Web API endpoints
        public static HttpConfiguration WebApiConfiguration { get; private set; }

        public void Configuration(IAppBuilder app)
        {
            // Establish Web API configuration
            WebApiConfiguration = new HttpConfiguration();
            WebApiConfiguration.Services.Replace(typeof(IExceptionHandler), new WebApiExceptionHandler());
            WebApiConfiguration.MapHttpAttributeRoutes();
            
            ConfigureAuth(app);

            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            app.UseWebApi(WebApiConfiguration);
        }
    }
}
