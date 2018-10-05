using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;

namespace E_Kataale.Models
{
    public class Supplier
    {

        public int ID { get; set; }
        public string Name { get; set; }
        public Bitmap Logo { get; set; }
        public PhysicalAddress Address { get; set; }

    }
}