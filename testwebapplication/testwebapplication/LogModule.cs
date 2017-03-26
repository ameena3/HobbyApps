using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace testwebapplication
{
    public class LogModule : IHttpModule
    {
        public LogModule()
        {

        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public void Init(HttpApplication context)
        {
            Console.WriteLine("This info was logged !!");
        }
    }
}