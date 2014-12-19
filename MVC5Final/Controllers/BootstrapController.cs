using MVC5Final.Models;
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

        private MVC5FinalContext db = new MVC5FinalContext();
        [Authorize]
        public ActionResult gettingstarted()
        {
            return View(db.GuestTable.ToList());
        }

        [OutputCache(Duration = 60, VaryByParam = "sitename")]
        public ActionResult Examples(string sitename)
        {
            if (string.IsNullOrEmpty(sitename)) sitename = "starter-template";
            StringBuilder sb = new StringBuilder();
            sb.Append("~/examples/" + sitename + "/index.html");
            return Redirect(sb.ToString());

        }



    }
}