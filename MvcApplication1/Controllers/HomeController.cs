using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestDll;

namespace MvcApplication1.Controllers
{
    [HandleError]
    public class HomeController : Controller
    {
        string te = test.Aa();
        public ActionResult Index()
        {
            ViewData["Message"] = te;

            return View();
        }

        public ActionResult About()
        {
            return View();
        }
    }
}
