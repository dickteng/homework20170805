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
            var data = new List<AccountViewModel>()
            {
                new AccountViewModel{Type=AccountType.收入,Date=new DateTime(2017,08,01),Amount=150},
                new AccountViewModel{Type=AccountType.支出,Date=new DateTime(2017,08,01),Amount=350},
                new AccountViewModel{Type=AccountType.收入,Date=new DateTime(2017,08,02),Amount=1200},
                new AccountViewModel{Type=AccountType.支出,Date=new DateTime(2017,08,02),Amount=150},
                new AccountViewModel{Type=AccountType.支出,Date=new DateTime(2017,08,03),Amount=2120},
                new AccountViewModel{Type=AccountType.支出,Date=new DateTime(2017,08,03),Amount=450},
                new AccountViewModel{Type=AccountType.支出,Date=new DateTime(2017,08,04),Amount=250},
                new AccountViewModel{Type=AccountType.收入,Date=new DateTime(2017,08,04),Amount=170}
            };

            return View(data);
        }
    }
}