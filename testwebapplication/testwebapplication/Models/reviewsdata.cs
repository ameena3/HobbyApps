using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace testwebapplication.Models
{
    public class reviewsdata 
    {
        public int id { get; set; }
        [Range(0,10)]
        public int rating { get; set; }
        [Display (Name = "Feedback") ]
        [Required (ErrorMessage = "Please provide a feedback")]
        public string Body { get; set; }
        public int restaurantID { get; set; }

    }
}