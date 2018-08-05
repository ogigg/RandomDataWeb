using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RandomDataWeb.Models
{
    public class RandomDataViewModel
    {
        public string FirstName{ get; set; }
        public string LastName { get; set; }
        public string Street { get; set; }
        public byte Number { get; set; }
        public string ZipCode { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
    }
}