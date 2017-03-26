using Microsoft.Owin.Builder;
using Microsoft.Owin.Hosting;
using Owin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AnubhavService
{
    public partial class Service1 : ServiceBase
    {
       public Thread thread = new Thread(new ThreadStart(threadwork));
        public Service1()
        {
            InitializeComponent();
        }
        public void ondebug()
        {
            OnStart(null);
        }
        protected override void OnStart(string[] args)
        {
            
            thread.Start();
            
        }

        public static void threadwork()
        {
            try
            {


                String uri = "http://anubhav:8080";
                using (WebApp.Start<Startup>(uri))
                {
                    Console.WriteLine("Starting the server!!");
                    System.IO.File.AppendAllText((AppDomain.CurrentDomain.BaseDirectory + "anubhavonstart.txt"), ("\n" + System.DateTime.Now +" Created the service and " +
                        "running the server"));
                    System.Threading.Thread.Sleep(System.Threading.Timeout.Infinite);

                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message.ToString());
            }
        }

        protected override void OnStop()
        {
            try
            {
                
                System.IO.File.AppendAllText((AppDomain.CurrentDomain.BaseDirectory + "anubhavonstop.txt"), "\n" + System.DateTime.Now + "  Stopping the server as the service no longer exists");
                thread.Abort();
                Console.WriteLine("Stopped the service!!");
                
            }
            catch (Exception)
            {

                Console.WriteLine("Cannot stop the service");
            }
        }
    }

    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            
            app.Run(ctx =>
                {
                    return ctx.Response.WriteAsync("Hello Anubhav welcome to your webserver");
                }
            );
        }
    }
}
