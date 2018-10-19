using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace E_Kataale.Models
{
    public class Product
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool PromoDept { get; set; }
        public bool PromoFront { get; set; }
        public bool InStock { get; set; }
        public Category Category { get; set; }
        public int ManufacturerID { get; set; }
    }
}