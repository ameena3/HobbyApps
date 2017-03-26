using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using testwebapplication.Models;

namespace testwebapplication.Controllers
{
    public class reviewsController : Controller
    {

        mynewonlineretaurant mr = new mynewonlineretaurant();


        // GET: reviews

        public ActionResult Index([Bind(Prefix = "id")] int? RestaurantID )
        {
            var model = mr.Restaurants.Find(RestaurantID);

            if(model != null)
            {
                return View(model);
            }
               

            return Content("The specified restaurant review does not exist..");         
        }

        // GET: reviews/Details/5
        public ActionResult Details(int id)
        {
            
            return View();
        }

        // GET: reviews/Create
        [HttpGet]
        public ActionResult Create(int? RestaurantID)
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(reviewsdata newreview)
        {
            if(ModelState.IsValid)
            {
                mr.review.Add(newreview);

                mr.SaveChanges();
                //return Content(newreview.id.ToString());
                return RedirectToAction("Index", new { id = newreview.restaurantID });

            }
            return View(newreview);
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            var model = mr.review.Find(id);
            return View(model);
        }

        [HttpPost]
        public ActionResult Edit(reviewsdata newreview)
        {
            if (ModelState.IsValid)
            {
                mr.Entry(newreview).State = System.Data.Entity.EntityState.Modified;

                mr.SaveChanges();
                //return Content(newreview.id.ToString());
                return RedirectToAction("Index", new { id = newreview.restaurantID });

            }
            return View(newreview);
        }
        protected override void Dispose(bool disposing)
        {
            if(mr != null)
            {
                mr.Dispose();
            }
            base.Dispose(disposing);
        }


    }
}
