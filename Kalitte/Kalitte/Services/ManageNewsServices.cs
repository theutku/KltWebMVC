using Kalitte.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using System.Globalization;
using System.IO;

namespace Kalitte.Services
{
    public class ManageNewsServices
    {

        private ApplicationDbContext db = new ApplicationDbContext();

        public static void FillNewsTypes(CreateNewsViewModel model)
        {
            model.NewsTypes = Enum.GetNames(typeof(NewsTypes.NewsCategory)).Select(category => new SelectListItem() { Text = category, Value = category });
        }

        public static void FillNewsModelDetails(News model)
        {
            model.ApplicationUserId = HttpContext.Current.User.Identity.GetUserId();
            model.CreationDate = DateTime.Now;
        }

        public List<News> GetAllNews()
        {
            List<News> allNews = this.db.News.ToList();
            return allNews;
        }

        public static string ConvertToBytes(HttpPostedFileBase image)
        {
            //byte[] imageBytes = null;
            //BinaryReader reader = new BinaryReader(image.InputStream);


            List<byte> bytes = new List<byte>();
            byte[] buffer = new byte[2000];
            int index = 0;
            int readedCount = 0;

            string imagePath = @"C:\Users\tansu\projects\utku\KltWebMVC\Kalitte\Kalitte\Content\Uploads\" + image.FileName;

            FileStream stream = File.Create(imagePath);

            while ((readedCount = image.InputStream.Read(buffer, 0, buffer.Length)) > 0)
            {
                index += readedCount;
                stream.Write(buffer, 0, readedCount);
                stream.Flush();
                buffer = new byte[2000];
            }

            stream.Close();
            return image.FileName;
        }
    }
}