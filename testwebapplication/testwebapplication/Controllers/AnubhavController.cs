using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace testwebapplication.Controllers
{
    public class AnubhavController : Controller
    {
        // GET: Anubhav

            //[Authorize]
        public ActionResult Index()
        {
            //throw new Exception("somethign terrible has happened Anubhav");
            return File("D:/NoVeLs & Comics/Speed Reading Courses/Triple Your Reading Speed-Mantesh/Torrent downloaded from Demonoid.txt", "test");
        }
    }
}