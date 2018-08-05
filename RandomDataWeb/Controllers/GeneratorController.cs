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
        // GET: Generator
        public ActionResult Index()
        {
            var randomDataViewModel = new RandomDataViewModel();

            return View(randomDataViewModel);
        }
    }
}