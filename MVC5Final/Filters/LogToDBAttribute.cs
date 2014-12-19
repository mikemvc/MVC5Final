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
            log("OnActionExecuting", filterContext.RouteData);
        }

        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            log("OnActionExecuted", filterContext.RouteData);
        }

        public override void OnResultExecuting(ResultExecutingContext filterContext)
        {
            log("OnResultExecuting", filterContext.RouteData);
        }

        public override void OnResultExecuted(ResultExecutedContext filterContext)
        {
            log("OnResultExecuted", filterContext.RouteData);
        }

        private void log(string method, RouteData routeData)
        {
            var controller = routeData.Values["controller"];
            var action = routeData.Values["action"];
            string message = String.Format("{0} - controller:{1} action:{2}",
                                           method, controller, action);
            //Debug.WriteLine(message, "Action Filter Log");
            
            MVC5FinalDB db = new MVC5FinalDB();
            
            SystemLog log = new SystemLog();
            log.ActionName = action.ToString();
            log.ControllerName = controller.ToString();
            log.UserName = "mike";
            log.IPAddress = "10.10.10.1";
            log.CreatedDate = DateTime.Now;
            log.Method = method;

            db.SystemLogs.Add(log);
            db.SaveChanges();

        }

    }
}