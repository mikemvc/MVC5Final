using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MVC5Final.Models;

namespace MVC5Final.Controllers
{
    [Authorize(Users="test@com.tw")]
    public class GuestTablesController : Controller
    {
        private MVC5FinalContext db = new MVC5FinalContext();

        // GET: GuestTables
        public ActionResult Index()
        {
            return View(db.GuestTable.ToList());
        }

        // GET: GuestTables/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            GuestTable guestTable = db.GuestTable.Find(id);
            if (guestTable == null)
            {
                return HttpNotFound();
            }
            return View(guestTable);
        }

        // GET: GuestTables/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: GuestTables/Create
        // 若要免於過量張貼攻擊，請啟用想要繫結的特定屬性，如需
        // 詳細資訊，請參閱 http://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Subject,Content,Email,PostDateTime,Name,Size,MimeType,FContent,approval")] GuestTable guestTable)
        {
            if (ModelState.IsValid)
            {
                db.GuestTable.Add(guestTable);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(guestTable);
        }

        // GET: GuestTables/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            GuestTable guestTable = db.GuestTable.Find(id);
            if (guestTable == null)
            {
                return HttpNotFound();
            }
            return View(guestTable);
        }

        // POST: GuestTables/Edit/5
        // 若要免於過量張貼攻擊，請啟用想要繫結的特定屬性，如需
        // 詳細資訊，請參閱 http://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Subject,Content,Email,PostDateTime,Name,Size,MimeType,FContent,approval")] GuestTable guestTable)
        {
            if (ModelState.IsValid)
            {
                db.Entry(guestTable).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(guestTable);
        }

        // GET: GuestTables/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            GuestTable guestTable = db.GuestTable.Find(id);
            if (guestTable == null)
            {
                return HttpNotFound();
            }
            return View(guestTable);
        }

        // POST: GuestTables/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            GuestTable guestTable = db.GuestTable.Find(id);
            db.GuestTable.Remove(guestTable);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
