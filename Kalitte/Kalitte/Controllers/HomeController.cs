using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Kalitte.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.PageHeader = "TARİHÇE";
            return View();
        }

        public ActionResult News()
        {
            ViewBag.PageHeader = "HABERLER";
            return View();
        }

        public ActionResult Services()
        {
            ViewBag.PageHeader = "HİZMETLER";
            return View();
        }
        public ActionResult Contact()
        {
            ViewBag.PageHeader = "İLETİŞİM";
            return View();
        }
    }
}