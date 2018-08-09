using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RandomDataWeb.Models;

namespace RandomDataWeb.Controllers
{
    public class GeneratorController : Controller
    {
        private MyDbContext _context;
        
        public GeneratorController()
        {
            _context = new MyDbContext();
        }

        // GET: Generator
        public ActionResult Index()
        {
            var rnd = new Random();
            var randomDataViewModel = new RandomDataViewModel
            {
                FirstName = _context.FirstNames.OrderBy(f => Guid.NewGuid()).First(),
                LastName = _context.LastNames.OrderBy(l => Guid.NewGuid()).First(),
                Street = _context.Streets.OrderBy(s => Guid.NewGuid()).First(),
                State = _context.States.OrderBy(s => Guid.NewGuid()).First(),
                City = _context.Cities.OrderBy(c => Guid.NewGuid()).First(),
                Number = rnd.Next(0,30),
                ZipCode = rnd.Next(0, 90).ToString("D2") + "-"+ rnd.Next(0, 990).ToString("D3")

            };

            return View(randomDataViewModel);
        }
    }
}