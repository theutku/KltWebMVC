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
            var allNews = this.db.News.ToList().Select(d => new NewsListingViewModel()
            {
                Body = d.Body,
                CreateDate = d.CreationDate,
                Header = d.Header,
                ImagePath = d.ImageData,
                SelectedNewsCategory = d.SelectedNewsCategory,
                UserName = d.User.UserName,
                Id = d.Id
            });
             

            return View(new HeaderedPageModel<IEnumerable<NewsListingViewModel>>("TÜM HABERLER",allNews));
            }

        // GET: ManageNews/Details/5
        public ActionResult Details(int id)
        { 
            News newsItem = this.db.News.Find(id);
            return View(new HeaderedPageModel<News>("HABER DETAYI", newsItem));
        }

        // GET: ManageNews/Create
        public ActionResult Create()
        {
            var model = new CreateNewsViewModel();
            ManageNewsServices.FillNewsTypes(model);
             
            return View(new ImportantHeaderPageModel<CreateNewsViewModel>("Yeni Haber Oluştur", model) { });
        }

        // POST: ManageNews/Create
        [HttpPost]
        public ActionResult Create(HeaderedPageModel<CreateNewsViewModel> model, HttpPostedFileBase newsImage)
        {
            //if (ModelState.IsValid)
            //{
            try
            {
                News insertData = new News();

                insertData.Body = model.PageModel.Body;
                insertData.Header = model.PageModel.Header;
                insertData.SelectedNewsCategory = model.PageModel.SelectedNewsCategory;


                // TODO: Add insert logic here
                string imageName = ManageNewsServices.ConvertToBytes(newsImage);
                insertData.ImageData = imageName;
                ManageNewsServices.FillNewsModelDetails(insertData);
                this.db.News.Add(insertData);
                this.db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                ManageNewsServices.FillNewsTypes(model.PageModel);
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
            News toDelete = new News { Id = id };
            this.db.News.Attach(toDelete);
            this.db.News.Remove(toDelete);
            this.db.SaveChanges();
            return RedirectToAction("Index");

        }

        // POST: ManageNews/Delete/5
        [HttpPost]
        public JsonResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                News toDelete = new News { Id = id };
                this.db.News.Attach(toDelete);
                this.db.News.Remove(toDelete);
                this.db.SaveChanges();
                return Json("Seçili haber silinmiştir.", JsonRequestBehavior.AllowGet);
            }
            catch
            {
                return Json("Silme Hatası!", JsonRequestBehavior.AllowGet);
            }
        }
    }
}
