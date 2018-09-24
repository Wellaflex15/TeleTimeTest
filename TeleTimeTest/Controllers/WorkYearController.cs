using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using TeleTimeTest.DAL;
using TeleTimeTest.Models;

namespace TeleTimeTest.Controllers
{
    public class WorkYearController : Controller
    {
        private TeleTimeTestContext db = new TeleTimeTestContext();

        // GET: WorkYear
        public ActionResult Index()
        {
            return View(db.WorkYears.ToList());
        }

        // GET: WorkYear/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            WorkYear workYear = db.WorkYears.Find(id);
            if (workYear == null)
            {
                return HttpNotFound();
            }
            return View(workYear);
        }

        // GET: WorkYear/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: WorkYear/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Year")] WorkYear workYear)
        {
            if (ModelState.IsValid)
            {
                db.WorkYears.Add(workYear);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(workYear);
        }

        // GET: WorkYear/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            WorkYear workYear = db.WorkYears.Find(id);
            if (workYear == null)
            {
                return HttpNotFound();
            }
            return View(workYear);
        }

        // POST: WorkYear/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Year")] WorkYear workYear)
        {
            if (ModelState.IsValid)
            {
                db.Entry(workYear).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(workYear);
        }

        // GET: WorkYear/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            WorkYear workYear = db.WorkYears.Find(id);
            if (workYear == null)
            {
                return HttpNotFound();
            }
            return View(workYear);
        }

        // POST: WorkYear/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            WorkYear workYear = db.WorkYears.Find(id);
            db.WorkYears.Remove(workYear);
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
