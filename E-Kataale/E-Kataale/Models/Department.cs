using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace E_Kataale.Models
{
    public class Department
    {

        public int ID { get;}

        [Required]
        [Display(Name="Department Name")]
        public string Name { get; set; }
        public string Code { get; }

        [DataType(DataType.MultilineText)]
        public string Description { get; set; }

    }
}