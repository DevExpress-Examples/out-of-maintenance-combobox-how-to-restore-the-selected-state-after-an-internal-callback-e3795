using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;
using DevExpress.Web.Mvc;

namespace MvcApp_Q367963 {
    public class HomeController : Controller {
        public ActionResult Index() {
            ViewBag.Message = "Welcome to DevExpress Extensions for ASP.NET MVC!";
            ViewData["ComboBoxValue"] = 5;
            return View();
        }

        public ActionResult ComboBoxPartial() {
            return PartialView("_PartialPage1");
        }
    }
}
