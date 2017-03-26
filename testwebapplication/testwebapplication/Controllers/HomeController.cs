using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using testwebapplication.Models;
using System.Web.Mvc;

namespace testwebapplication.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            var controller = RouteData.Values["controller"];
            var name = RouteData.Values["action"];
            var id = RouteData.Values["id"];
            var message = String.Format("{0}{1}{2}", controller, name, id);
            ViewBag.Message = message;
            ViewBag.Location = "United states of America in Chicago";
            mymodel mm = new mymodel();
            mm.name = "Anubhav";
            mm.lastname = "Meena";

            return View(mm);
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}