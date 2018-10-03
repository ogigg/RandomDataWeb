using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;
using System.Web.Http.Results;
using RandomDataWeb.Models;

namespace RandomDataWeb.Controllers.Api
{
  public class DownloadDataController : ApiController
  {
    private MyDbContext _context;

    public DownloadDataController()
    {
      _context = new MyDbContext();
    }

    //GET /api/DownloadData
    [System.Web.Http.HttpGet]
    public HttpResponseMessage DownloadData()
    {
      var rnd = new Random();
      string dataString = _context.FirstNames.OrderBy(f => Guid.NewGuid()).First().Name + " " +
                          _context.LastNames.OrderBy(l => Guid.NewGuid()).First().NameMale + " " +
                          _context.Streets.OrderBy(s => Guid.NewGuid()).First().Name + " " +
                          rnd.Next(1, 30) + " " +
                          _context.Cities.OrderBy(c => Guid.NewGuid()).First().Name + " " +
                          rnd.Next(5, 90).ToString("D2") + "-" + rnd.Next(0, 990).ToString("D3") + " " +
                          _context.States.OrderBy(s => Guid.NewGuid()).First().Name + " " +
                          Path.GetRandomFileName().Replace(".", "") + "@mail.com" + " " +
                          rnd.Next(400000000, 800000000);
      var httpResponse = new HttpResponseMessage(HttpStatusCode.OK);

      httpResponse.Content = new StreamContent(new MemoryStream(Encoding.UTF8.GetBytes(dataString)));
      httpResponse.Content.Headers.ContentType = new MediaTypeHeaderValue("application/octet-stream");
      httpResponse.Content.Headers.ContentDisposition = new ContentDispositionHeaderValue("attachment");
      httpResponse.Content.Headers.ContentDisposition.FileName = "RandomData.txt";
      return httpResponse;
    }
    //GET /api/DownloadData/100
    [HttpGet]
    [Route ("api/DownloadData/{count}")]
    public HttpResponseMessage DownloadData(int count)
    {
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
      var httpResponse = new HttpResponseMessage(HttpStatusCode.OK);

      httpResponse.Content = new StreamContent(new MemoryStream(Encoding.UTF8.GetBytes(sb.ToString())));
      httpResponse.Content.Headers.ContentType = new MediaTypeHeaderValue("application/octet-stream");
      httpResponse.Content.Headers.ContentDisposition = new ContentDispositionHeaderValue("attachment");
      httpResponse.Content.Headers.ContentDisposition.FileName = "RandomData.txt";
      return httpResponse;
    }
  }
}
