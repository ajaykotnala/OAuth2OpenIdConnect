using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace WebApi.App_Start
{
    public class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            config.Routes.MapHttpRoute(
                name: "AllConsumer",
                routeTemplate: "consumer",
                defaults: new { controller = "Consumer", action = "Get" }
                );
        }
    }
}