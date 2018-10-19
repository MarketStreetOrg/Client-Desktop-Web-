﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace E_Kataale.Models
{
    public class Department
    {
        
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        ///<summary>
        ///Returns the number of Categories in the department
        ///</summary>
        public int Categories { get; set; }

       
    }
}