using Kalitte.Models;
using Kalitte.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Kalitte.Controllers
{

    [AllowOnlyAdmin]
    public class ManageNewsController : Controller
    {

        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: ManageNews
        public ActionResult Index()
        {
            List<News> allNews = this.db.News.ToList();
            ViewBag.PageHeader = "TÜM HABERLER";
            return View(allNews);
        }

        // GET: ManageNews/Details/5
        public ActionResult Details(int id)
        {
            ViewBag.PageHeader = "HABER DETAYI";
            News newsItem = this.db.News.Find(id);
            return View(newsItem);
        }

        // GET: ManageNews/Create
        public ActionResult Create()
        {
            var model = new News();
            ManageNewsServices.FillNewsTypes(model);

            ViewBag.PageHeader = "Yeni Haber Oluştur";

            return View(model);
        }

        // POST: ManageNews/Create
        [HttpPost]
        public ActionResult Create(News model, HttpPostedFileBase newsImage)
        {
            //if (ModelState.IsValid)
            //{
            try
            {
                // TODO: Add insert logic here
                string imageName = ManageNewsServices.ConvertToBytes(newsImage);
                model.ImageData = imageName;
                ManageNewsServices.FillNewsModelDetails(model);
                this.db.News.Add(model);
                this.db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                ManageNewsServices.FillNewsTypes(model);
                return View(model);
            }
            //}

            //ManageNewsServices.FillNewsTypes(model);
            //return View(model);

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
