using System;
using System.Data;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace RandomDataWeb.Models
{
    public class MyDbContext : DbContext
    {
        public DbSet<City> Cities { get; set; }
        public DbSet<FirstName> FirstNames { get; set; }
        public DbSet<LastName> LastNames { get; set; }
        public DbSet<Street> Streets { get; set; }
        public DbSet<State> States { get; set; }


        public MyDbContext()
        {



        }
    }
}