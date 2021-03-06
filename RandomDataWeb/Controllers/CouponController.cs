﻿using System.Web.Mvc;
using RandomDataWeb.Models;

namespace RandomDataWeb.Areas.HelpPage.Controllers
{
    public class CouponController : Controller
    {
        private MyDbContext _context;

        public CouponController()
        {
            _context = new MyDbContext();
        }

        public ActionResult Index()
        {
            ViewBag.Title = "Dodaj nowy kupon";

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Save(Coupon coupon)
        {
            if (!ModelState.IsValid)
            {
                return View("Index", coupon);
            }

            _context.Coupons.Add(coupon);

            _context.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}