using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace testwebapplication.Models
{
    public class mymodel
    {
        [System.ComponentModel.DataAnnotations.Key]
        public int keyreq { get; set; }
        public string name { get; set; }
        public string lastname { get; set; }
    }
}