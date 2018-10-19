using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace E_Kataale.Models
{
    public class Category
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        
        [Display(Name="Department Name")]
        public Department Department { get; set; }
        /// <summary>
        /// Returns the number of products within this category
        /// </summary>
        public int Products { get; set; }



    }
}