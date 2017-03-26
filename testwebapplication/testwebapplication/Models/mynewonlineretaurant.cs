using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace testwebapplication.Models
{
    public class mynewonlineretaurant : DbContext
    {
        public mynewonlineretaurant() : base("name=DefaultConnection")
        {

        }
        public DbSet<Restaurant> Restaurants { get; set; }
        public DbSet<reviewsdata> review { get; set; }
        public DbSet<mymodel> name { get; set; }
    }
}