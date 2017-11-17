using Kalitte.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using System.Globalization;

namespace Kalitte.Services
{
    public class ManageNewsServices
    {

        private ApplicationDbContext db = new ApplicationDbContext();

        public static void FillNewsTypes(News model)
        {
            model.NewsTypes = Enum.GetNames(typeof(NewsTypes.NewsCategory)).Select(category => new SelectListItem() { Text = category, Value = category });
        }

        public static void FillNewsModelDetails (News model)
        {
            model.CreatedBy = HttpContext.Current.User.Identity.GetUserId();
            model.CreationDate = DateTime.Now;
        }

        public List<News> GetAllNews()
        {
            List<News> allNews = this.db.News.ToList();
            return allNews;
        }
    }
}