using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace E_Kataale.Models
{
    public abstract class Address
    {

        public int ID { get;}
        public string PhoneNumber { get; set; }
        public string WorkNumber { get; set; }
        public string Email { get; set; }

        public abstract void WriteAddress(string PhoneNumber, string WorkNumber, string Email);
        
            
    }

    public class PhysicalAddress : Address
    {
        string Address1, Address2, Address3;

        public PhysicalAddress(string PhoneNumber, string WorkNumber, string Email,string Address1=null,string Address2=null,string Address3=null)
        {

            WriteAddress(PhoneNumber, WorkNumber, Email);
            this.Address1 = Address1;
            this.Address2 = Address2;
            this.Address3 = Address3;
        }

        public override void WriteAddress(string PhoneNumber, string WorkNumber, string Email)
        {
            this.PhoneNumber = PhoneNumber;
            this.WorkNumber = WorkNumber;
            this.Email = Email;
        }

        public PhysicalAddress()
        {

        }

    }


}