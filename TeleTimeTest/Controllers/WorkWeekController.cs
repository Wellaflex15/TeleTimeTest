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
    public class WorkWeekController : Controller
    {
        private TeleTimeTestContext db = new TeleTimeTestContext();

        // GET: WorkWeek
        public ActionResult Index()
        {
            var workWeeks = db.WorkWeeks.Include(w => w.WorkYear);
            return View(workWeeks.ToList());
        }

        // GET: WorkWeek/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            WorkWeek workWeek = db.WorkWeeks.Find(id);
            if (workWeek == null)
            {
                return HttpNotFound();
            }
            return View(workWeek);
        }

        // GET: WorkWeek/Create
        public ActionResult Create()
        {
            ViewBag.YearID = new SelectList(db.WorkYears, "YearID", "YearID");
            return View();
        }

        // POST: WorkWeek/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "WeekNumberID,YearID")] WorkWeek workWeek)
        {
            if (ModelState.IsValid)
            {
                db.WorkWeeks.Add(workWeek);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.YearID = new SelectList(db.WorkYears, "YearID", "YearID", workWeek.YearID);
            return View(workWeek);
        }

        // GET: WorkWeek/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            WorkWeek workWeek = db.WorkWeeks.Find(id);
            if (workWeek == null)
            {
                return HttpNotFound();
            }
            ViewBag.YearID = new SelectList(db.WorkYears, "YearID", "YearID", workWeek.YearID);
            return View(workWeek);
        }

        // POST: WorkWeek/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "WeekNumberID,YearID")] WorkWeek workWeek)
        {
            if (ModelState.IsValid)
            {
                db.Entry(workWeek).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.YearID = new SelectList(db.WorkYears, "YearID", "YearID", workWeek.YearID);
            return View(workWeek);
        }

        // GET: WorkWeek/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            WorkWeek workWeek = db.WorkWeeks.Find(id);
            if (workWeek == null)
            {
                return HttpNotFound();
            }
            return View(workWeek);
        }

        // POST: WorkWeek/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            WorkWeek workWeek = db.WorkWeeks.Find(id);
            db.WorkWeeks.Remove(workWeek);
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
