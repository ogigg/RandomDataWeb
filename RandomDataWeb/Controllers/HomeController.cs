using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Web;
using System.Web.Mvc;
using CsvHelper;
using RandomDataWeb.Models;

namespace RandomDataWeb.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Generator losowych danych";
            return View();
        }
    }
}
