using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using RandomDataWeb.Models;

namespace RandomDataWeb.Controllers.Api
{
    public class RandomDataController : ApiController
    {
        private MyDbContext _context;

        public RandomDataController()
        {
            _context = new MyDbContext();
        }
        //GET /api/RandomData
        public RandomDataViewModel GetRandomData()
        {
            var rnd = new Random();
            return new RandomDataViewModel()
            {
                FirstName = _context.FirstNames.OrderBy(f => Guid.NewGuid()).First(),
                LastName = _context.LastNames.OrderBy(l => Guid.NewGuid()).First(),
                Street = _context.Streets.OrderBy(s => Guid.NewGuid()).First(),
                Number = rnd.Next(1, 30),
                City = _context.Cities.OrderBy(c => Guid.NewGuid()).First(),
                ZipCode = rnd.Next(5, 90).ToString("D2") + "-" + rnd.Next(0, 990).ToString("D3"),
                State = _context.States.OrderBy(s => Guid.NewGuid()).First()
            };
        }
    }
}
