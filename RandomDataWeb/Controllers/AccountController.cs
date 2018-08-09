using System.Web.Mvc;
using RandomDataWeb.Models;

namespace RandomDataWeb.Areas.HelpPage.Controllers
{
    public class AccountController : Controller
    {
        private MyDbContext _context;

        public AccountController()
        {
            _context = new MyDbContext();
        }

        public ActionResult Index()
        {
            ViewBag.Title = "Dodaj nowego użytkownika";
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Save(Account account)
        {
            if (!ModelState.IsValid)
            {
                return View("Index", account);
            }

            _context.Accounts.Add(account);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}
