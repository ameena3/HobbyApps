using System;
using System.Collections.Generic;

namespace testwebapplication.Models
{
    public class Restaurant
    {
        public int ID { get; set; }
        public String name { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public virtual ICollection<reviewsdata> reviews { get; set; }
    }
}