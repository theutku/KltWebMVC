using Kalitte.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Kalitte.Services
{
    public class ManageNewsServices
    {
        private ApplicationDbContext db;

        public ManageNewsServices(ApplicationDbContext db)
        {
            this.db = db;
        }

        public void CreateNews()
        {

        }

    }
}