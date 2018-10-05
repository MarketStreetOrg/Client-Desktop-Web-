using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace E_Kataale.Models
{
    public class Market
    {
        public int ID {get;}
        public string Name { get; set; }
        public PhysicalAddress Address { get; set; }
        public string Description { get; set; }

    }
}