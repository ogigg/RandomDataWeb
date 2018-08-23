using System.IO;
using System.Reflection;
using System.Text;
using CsvHelper;
using RandomDataWeb.Models;

namespace RandomDataWeb.Migrations
{
    using RandomDataWeb.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<MyDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(MyDbContext context)
        {
        //    Assembly assembly = Assembly.GetExecutingAssembly();
        //    string resourceName = "RandomDataWeb.Models.SeedData.FirstNames.csv";
        //    using (Stream stream = assembly.GetManifestResourceStream(resourceName))
        //    {
        //        using (StreamReader reader = new StreamReader(stream, Encoding.Default))
        //        {
        //            CsvReader csvReader = new CsvReader(reader);
        //            csvReader.Configuration.MissingFieldFound = null;
        //            csvReader.Configuration.HeaderValidated = null;
        //            var firstNames = csvReader.GetRecords<FirstName>().ToArray();
        //            context.FirstNames.AddOrUpdate(f => f.Name, firstNames);
        //        }
        //    }
        //    resourceName = "RandomDataWeb.Models.SeedData.Streets.csv";
        //    using (Stream stream = assembly.GetManifestResourceStream(resourceName))
        //    {
        //        using (StreamReader reader = new StreamReader(stream, Encoding.Default))
        //        {
        //            CsvReader csvReader = new CsvReader(reader);
        //            csvReader.Configuration.MissingFieldFound = null;
        //            csvReader.Configuration.HeaderValidated = null;
        //            var streets = csvReader.GetRecords<Street>().ToArray();
        //            context.Streets.AddOrUpdate(s => s.Name, streets);
        //        }
        //    }
        //    resourceName = "RandomDataWeb.Models.SeedData.LastNames.csv";
        //    using (Stream stream = assembly.GetManifestResourceStream(resourceName))
        //    {
        //        using (StreamReader reader = new StreamReader(stream, Encoding.Default))
        //        {
        //            CsvReader csvReader = new CsvReader(reader);
        //            csvReader.Configuration.MissingFieldFound = null;
        //            csvReader.Configuration.HeaderValidated = null;
        //            var firstNames = csvReader.GetRecords<LastName>().ToArray();
        //            context.LastNames.AddOrUpdate(f => f.NameMale, firstNames);
        //        }
        //    }
        //    resourceName = "RandomDataWeb.Models.SeedData.Cities.csv";
        //    using (Stream stream = assembly.GetManifestResourceStream(resourceName))
        //    {
        //        using (StreamReader reader = new StreamReader(stream, Encoding.Default))
        //        {
        //            CsvReader csvReader = new CsvReader(reader);
        //            csvReader.Configuration.MissingFieldFound = null;
        //            csvReader.Configuration.HeaderValidated = null;
        //            var cities = csvReader.GetRecords<City>().ToArray();
        //            context.Cities.AddOrUpdate(c => c.Name, cities);
        //        }
        //    }
        //    resourceName = "RandomDataWeb.Models.SeedData.States.csv";
        //    using (Stream stream = assembly.GetManifestResourceStream(resourceName))
        //    {
        //        using (StreamReader reader = new StreamReader(stream, Encoding.Default))
        //        {
        //            CsvReader csvReader = new CsvReader(reader);
        //            csvReader.Configuration.MissingFieldFound = null;
        //            csvReader.Configuration.HeaderValidated = null;
        //            var states = csvReader.GetRecords<State>().ToArray();
        //            context.States.AddOrUpdate(s => s.Name, states);
        //        }
        //    }

        //    context.SaveChanges();
        }
    }
}
