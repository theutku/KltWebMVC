using Kalitte.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Kalitte.Controllers
{
    public class ManageNewsController : Controller
    {

        private ApplicationDbContext db = new ApplicationDbContext();
        // GET: ManageNews
        public ActionResult Index()
        {
            return View();
        }

        // GET: ManageNews/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ManageNews/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ManageNews/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
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
