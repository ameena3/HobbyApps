using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using testwebapplication.CustomHandlers;

namespace testwebapplication
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.Add(new Route("home/about", new sample()));
            routes.MapRoute(
                                name: "myname",
                                url: "{controller}/{action}/{id}",
                                defaults: new { controller = "Restaurants", action = "Index", id = UrlParameter.Optional }
                            );

            routes.MapRoute(
                        name: "anubhav",
                                url: "{controller}/{action}/{id}",
                                defaults: new { controller = "Anubhav", action = "Index", id = UrlParameter.Optional }
                            );


            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
    public class sample : IRouteHandler
    {
        public IHttpHandler GetHttpHandler(RequestContext requestContext)
        {
            return new myhandler();
        }
    }
}
