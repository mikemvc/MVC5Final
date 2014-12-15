using System;
using System.Collections.Generic;
using System.Linq;
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
    }
}