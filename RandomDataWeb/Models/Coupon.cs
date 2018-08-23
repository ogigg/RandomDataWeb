using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RandomDataWeb.Models
{
    public class Coupon
    {
        public int Id { get; set; }

        [DisplayName("Kod")]
        [Required]
        [MaxLength(15)]
        public string CouponCode{ get; set; }
    }
}