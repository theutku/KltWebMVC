using Kalitte.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using System.Web.Routing;

namespace Kalitte.Services
{
    public class AllowOnlyAdmin: ActionFilterAttribute
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            string currentUserId = HttpContext.Current.User.Identity.GetUserId();

            if(currentUserId == null)
            {
                filterContext.Result = new RedirectToRouteResult(new RouteValueDictionary { { "controller", "home" }, { "action", "Unauthorized" } });
            }
            base.OnActionExecuting(filterContext);
        }
    }
}