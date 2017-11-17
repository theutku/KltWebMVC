using Kalitte.Models;
using Kalitte.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using System.Globalization;

namespace Kalitte.Controllers
{

    [AllowOnlyAdmin]
    public class ManageNewsController : Controller
    {

        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: ManageNews
        public ActionResult Index()
        {
            List<NewsModel> allNews = this.db.CreatedNews.ToList();
            return View(allNews);
        }

        // GET: ManageNews/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ManageNews/Create
        public ActionResult Create()
        {
            var model = new NewsModel();
            ManageNewsServices.FillNewsTypes(model);

            ViewBag.PageHeader = "Yeni Haber Oluştur";

            return View(model);
        }

        // POST: ManageNews/Create
        [HttpPost]
        public ActionResult Create(NewsModel model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    // TODO: Add insert logic here
                    model.CreatedBy = User.Identity.GetUserId();
                    DateTime now = new DateTime();
                    string isoNow = now.ToString("o", CultureInfo.InvariantCulture);
                    model.CreationDate = isoNow;
                    this.db.CreatedNews.Add(model);

                    return RedirectToAction("Index");
                }
                catch
                {
                    ManageNewsServices.FillNewsTypes(model);
                    return View(model);
                }
            }

            ManageNewsServices.FillNewsTypes(model);
            return View(model);

        }

        // GET: ManageNews/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ManageNews/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: ManageNews/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ManageNews/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
