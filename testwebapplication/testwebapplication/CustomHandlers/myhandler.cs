using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace testwebapplication.CustomHandlers
{
    public class myhandler : IHttpHandler
    {

        bool IHttpHandler.IsReusable => false;

        public void ProcessRequest(HttpContext context)
        {
            context.Response.Write("<p>Hey this is my handler </p>");
        }
    }
}