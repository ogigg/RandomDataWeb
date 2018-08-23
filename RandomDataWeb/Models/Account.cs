using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RandomDataWeb.Models
{
    public class Account
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(25)]
        public string Email { get; set; }

        [DisplayName("Komentarz")]
        [Required]
        [MaxLength(25)]
        public string Password { get; set; }
    }
}