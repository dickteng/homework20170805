using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using homework20170805.Models;

namespace homework20170805.Controllers
{
    public class HomeController : Controller
    {
        private AccountService data = new AccountService();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult ShowBookKeeping()
        {
            //AccountService data=new AccountService();
            return View( data.Getdata());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(AccountBook accountbook)
        {
            if (ModelState.IsValid)
            {
                data.SaveChanges(accountbook);
            }

            return RedirectToAction("Index");
        }

    }
}