using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace MVC5Final.Controllers
{
    public class BootstrapController : Controller
    {
        // GET: Bootstrap
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult gettingstarted()
        {
            return View();
        }
        
        public ActionResult Examples(string sitename)
        {
            if (string.IsNullOrEmpty(sitename)) sitename = "starter-template";
            StringBuilder sb = new StringBuilder();
            sb.Append("~/examples/" + sitename + "/index.html");
            return Redirect(sb.ToString());

        }



    }
}