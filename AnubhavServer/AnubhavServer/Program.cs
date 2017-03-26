using Microsoft.Owin.Diagnostics;
using Microsoft.Owin.Hosting;
using Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnubhavServer
{
    class Program
    {
        static void Main(string[] args)
        {
            String uri = "http://anubhav:8080";
            using (WebApp.Start<Startup>(uri))
            {
                Console.WriteLine("Stated the anubhav Server");
                Console.ReadKey();
                Console.WriteLine("Stopping the server");
            }
        }
    }

    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.UseWelcomePage("");
            app.Run(ctx =>
            {
                return ctx.Response.WriteAsync("Hey there Anubhav");
            });
        }
    }


}
