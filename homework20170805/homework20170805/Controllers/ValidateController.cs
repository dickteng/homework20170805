using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace homework20170805.Controllers
{
    public class ValidateController : Controller
    {
        public JsonResult CheckDate(DateTime Dateee)
        {
            bool isValidate = true;
            if ( DateTime.Now<Dateee)
            {
                isValidate = false;
            }
            return Json(isValidate, JsonRequestBehavior.AllowGet);
        }
    }
}