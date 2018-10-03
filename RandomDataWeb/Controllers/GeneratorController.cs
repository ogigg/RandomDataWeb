using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Http.Results;
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
                Number = rnd.Next(1,30),
                ZipCode = rnd.Next(5, 90).ToString("D2") + "-"+ rnd.Next(0, 990).ToString("D3"),
                Email = Path.GetRandomFileName().Replace(".", "") + "@mail.com",
                Phone = rnd.Next(400000000, 800000000)
            };

            return View(randomDataViewModel);
        }

      public ActionResult DownloadData(int count)
    { //\r\n
      var rnd = new Random();

      var sb = new System.Text.StringBuilder();
      for (int i = 0; i < count; i++)
      {
        sb.AppendLine(_context.FirstNames.OrderBy(f => Guid.NewGuid()).First().Name + " " +
                      _context.LastNames.OrderBy(l => Guid.NewGuid()).First().NameMale + " " +
                      _context.Streets.OrderBy(s => Guid.NewGuid()).First().Name + " " +
                      rnd.Next(1, 30) + " " +
                      _context.Cities.OrderBy(c => Guid.NewGuid()).First().Name + " " +
                      rnd.Next(5, 90).ToString("D2") + "-" + rnd.Next(0, 990).ToString("D3") + " " +
                      _context.States.OrderBy(s => Guid.NewGuid()).First().Name + " " +
                      Path.GetRandomFileName().Replace(".", "") + "@mail.com" + " " +
                      rnd.Next(400000000, 800000000)
                      );
      }

      Response.Clear();
        Response.AddHeader("content-disposition", "attachment; filename=RandomData.txt");
        Response.AddHeader("content-type", "text/plain");

        using (StreamWriter writer = new StreamWriter(Response.OutputStream))
        {
          writer.WriteLine(sb.ToString());
        }
        Response.End();
        return View("Index");
      }
    }
}
