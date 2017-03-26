using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace testwebapplication.Models
{
    public class Restaurantviewmodel
    {
        public int ID { get; set; }
        public String name { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public ICollection<reviewsdata> reviews { get; set; }
        public int noofreviews { get; set; }
    }
}