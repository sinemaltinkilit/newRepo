using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace rehberApp.Models
{
    public class rehber
    {
        [Key]
        public int id { get; set; }
        public string adi { get; set; }
        public string soyadi { get; set; }
        public int numara { get; set; }

    }
}