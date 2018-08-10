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
            Assembly assembly = Assembly.GetExecutingAssembly();
            string resourceName = "RandomDataWeb.Models.SeedData.FirstNames.csv";
            using (Stream stream = assembly.GetManifestResourceStream(resourceName))
            {
                using (StreamReader reader = new StreamReader(stream, Encoding.Default))
                {
                    CsvReader csvReader = new CsvReader(reader);
                    csvReader.Configuration.MissingFieldFound = null;
                    csvReader.Configuration.HeaderValidated = null;
                    var firstNames = csvReader.GetRecords<FirstName>().ToArray();
                    return View(firstNames);
                }
            }
            ViewBag.Title = "Generator losowych danych";

            //return View(firstNames);
        }
    }
}
