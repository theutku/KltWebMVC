using Kalitte.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Kalitte.Services
{
    public class ManageNewsServices
    {
        private ApplicationDbContext db;

        public ManageNewsServices(ApplicationDbContext db)
        {
            this.db = db;
        }

        public static void FillNewsTypes(NewsModel model)
        {
            model.NewsTypes = Enum.GetNames(typeof(NewsTypes.NewsCategory)).Select(category => new SelectListItem() { Text = category, Value = category });
        }

    }
}