using Kalitte.Models;
using Kalitte.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Kalitte.Controllers
{
    public class HomeController : Controller
    {

        private ManageNewsServices newsHelper = new ManageNewsServices();
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
            List<News> allNews = this.newsHelper.GetAllNews();
            return View(allNews);
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

        public ActionResult Unauthorized()
        {
            ViewBag.PageHeader = "ERİŞİM ENGELLENDİ";
            return View("Unauthorized");
        }
    }
}