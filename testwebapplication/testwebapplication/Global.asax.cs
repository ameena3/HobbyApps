using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using testwebapplication;
using testwebapplication.Models;

[assembly: PreApplicationStartMethod(typeof(MvcApplication),"Register")]

namespace testwebapplication
{
    public class MvcApplication : System.Web.HttpApplication
    {
        public static void Register()
        {
            HttpApplication.RegisterModule(typeof(LogModule));
        }
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
        protected void Application_PreRequestHandlerExecute()
        {
            Console.WriteLine("Hanler going to execute");
        }

        protected void Application_PostRequestHandlerExecute()
        {
            Console.WriteLine("handler executed");
        }

        protected void Application_Stop()
        {
            Console.WriteLine("Ending the application Anubhav");
        }
    }
}
