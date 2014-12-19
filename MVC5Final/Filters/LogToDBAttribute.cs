using MVC5Final.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MVC5Final.Filters
{
    public class LogToDBAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            if (filterContext.HttpContext.User.Identity.IsAuthenticated)
            {
                SystemLog logdata = new SystemLog();
                logdata.UserName = filterContext.HttpContext.User.Identity.Name;
                log("OnActionExecuting", filterContext.RouteData, logdata);
            }
        }

        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            if (filterContext.HttpContext.User.Identity.IsAuthenticated)
            {
                SystemLog logdata = new SystemLog();
                logdata.UserName = filterContext.HttpContext.User.Identity.Name;
                log("OnActionExecuted", filterContext.RouteData, logdata);
            }
        }

        public override void OnResultExecuting(ResultExecutingContext filterContext)
        {
            if (filterContext.HttpContext.User.Identity.IsAuthenticated)
            {
                SystemLog logdata = new SystemLog();
                logdata.UserName = filterContext.HttpContext.User.Identity.Name;
                log("OnResultExecuting", filterContext.RouteData, logdata);
            }
        }

        public override void OnResultExecuted(ResultExecutedContext filterContext)
        {
            if (filterContext.HttpContext.User.Identity.IsAuthenticated)
            {
                SystemLog logdata = new SystemLog();
                logdata.UserName = filterContext.HttpContext.User.Identity.Name;
                log("OnResultExecuted", filterContext.RouteData, logdata);
            }
        }

        private void log(string method, RouteData routeData, SystemLog log)
        {
            var controller = routeData.Values["controller"];
            var action = routeData.Values["action"];
            string message = String.Format("{0} - controller:{1} action:{2}",
                                           method, controller, action);
            //Debug.WriteLine(message, "Action Filter Log");
            
            MVC5FinalDB db = new MVC5FinalDB();
            
            log.ActionName = action.ToString();
            log.ControllerName = controller.ToString();
            log.IPAddress = "10.10.10.1";
            log.CreatedDate = DateTime.Now;
            log.Method = method;



            db.SystemLogs.Add(log);
            db.SaveChanges();

        }

    }
}