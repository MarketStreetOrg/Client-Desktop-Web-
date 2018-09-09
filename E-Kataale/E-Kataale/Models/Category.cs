using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace E_Kataale.Models
{
    public class Category
    {
        public int ID { get;}

        [Required]
        public string Name { get; set; }

        public int DepartmentID { get;}

        [Required]
        [Display(Name="Department Name")]
        public string Department { get; set; }
        
        public string Description { get; set; }


        protected string GetDepartment(int ID)
        {
            return "Not Filled Yet";
        }

      

    }
}