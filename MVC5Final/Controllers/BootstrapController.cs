using MVC5Final.Models;
using System;
using System.Collections.Generic;
using System.IO;
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

        [HttpPost]
        public ActionResult UploadToDB(HttpPostedFileBase file)
        {
            //if (file != null && file.ContentLength > 0)
            //{
            //    string fileName = Path.GetFileName(file.FileName);
            //    int length = file.ContentLength;
            //    byte[] buffer = new byte[length];
            //    // 讀取Stream，寫入buffer
            //    file.InputStream.Read(buffer, 0, length);

            //    DbFile dbfile = new DbFile()
            //    {
            //        Name = fileName,
            //        MimeType = file.ContentType,
            //        Size = file.ContentLength,
            //        Content = buffer
            //    };
            //    try
            //    {
            //        db.DbFile.Add(dbfile);
            //        db.SaveChanges();
            //        string message = "Name:" + fileName + ",<br>" +
            //                         "Content Type:" + file.ContentType + ",<br>" +
            //                         "Size:" + file.ContentLength + ",<br>" +
            //                         "上傳成功.";
            //        TempData["Message"] = message;
            //    }
            //    catch (Exception ex)
            //    {
            //        TempData["Message"] = "儲存錯誤：" + ex.Message;
            //    }
            //}
            //else
            //{
            //    TempData["Message"] = "未選擇或空白檔案。";
            //}
            return View();
        }

    }
}