using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RandomDataWeb.Models
{
    public class RandomDataViewModel
    {
        [Key]
        public FirstName FirstName{ get; set; }
        public LastName LastName { get; set; }
        public Street Street { get; set; }
        public byte Number { get; set; }
        public string ZipCode { get; set; }
        public City City { get; set; }
        public State State { get; set; }

    }
}