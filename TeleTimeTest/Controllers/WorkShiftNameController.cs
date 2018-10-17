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
    public class WorkShiftNameController : Controller
    {
        private TeleTimeTestContext db = new TeleTimeTestContext();

        // GET: WorkShiftName
        public ActionResult Index()
        {
            return View(db.WorkShiftNames.ToList());
        }

        // GET: WorkShiftName/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            WorkShiftName workShiftName = db.WorkShiftNames.Find(id);
            if (workShiftName == null)
            {
                return HttpNotFound();
            }
            return View(workShiftName);
        }

        // GET: WorkShiftName/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: WorkShiftName/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "WorkShiftNameName")] WorkShiftName workShiftName)
        {
            if (ModelState.IsValid)
            {
                db.WorkShiftNames.Add(workShiftName);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(workShiftName);
        }

        // GET: WorkShiftName/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            WorkShiftName workShiftName = db.WorkShiftNames.Find(id);
            if (workShiftName == null)
            {
                return HttpNotFound();
            }
            return View(workShiftName);
        }

        // POST: WorkShiftName/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "WorkShiftNameName")] WorkShiftName workShiftName)
        {
            if (ModelState.IsValid)
            {
                db.Entry(workShiftName).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(workShiftName);
        }

        // GET: WorkShiftName/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            WorkShiftName workShiftName = db.WorkShiftNames.Find(id);
            if (workShiftName == null)
            {
                return HttpNotFound();
            }
            return View(workShiftName);
        }

        // POST: WorkShiftName/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            WorkShiftName workShiftName = db.WorkShiftNames.Find(id);
            db.WorkShiftNames.Remove(workShiftName);
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
