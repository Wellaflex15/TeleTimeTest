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
    public class TypeOfShiftController : Controller
    {
        private TeleTimeTestContext db = new TeleTimeTestContext();

        // GET: TypeOfShift
        public ActionResult Index()
        {
            return View(db.TypeOfShifts.ToList());
        }

        // GET: TypeOfShift/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TypeOfShift typeOfShift = db.TypeOfShifts.Find(id);
            if (typeOfShift == null)
            {
                return HttpNotFound();
            }
            return View(typeOfShift);
        }

        // GET: TypeOfShift/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TypeOfShift/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ShiftName")] TypeOfShift typeOfShift)
        {
            if (ModelState.IsValid)
            {
                db.TypeOfShifts.Add(typeOfShift);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(typeOfShift);
        }

        // GET: TypeOfShift/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TypeOfShift typeOfShift = db.TypeOfShifts.Find(id);
            if (typeOfShift == null)
            {
                return HttpNotFound();
            }
            return View(typeOfShift);
        }

        // POST: TypeOfShift/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ShiftName")] TypeOfShift typeOfShift)
        {
            if (ModelState.IsValid)
            {
                db.Entry(typeOfShift).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(typeOfShift);
        }

        // GET: TypeOfShift/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TypeOfShift typeOfShift = db.TypeOfShifts.Find(id);
            if (typeOfShift == null)
            {
                return HttpNotFound();
            }
            return View(typeOfShift);
        }

        // POST: TypeOfShift/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            TypeOfShift typeOfShift = db.TypeOfShifts.Find(id);
            db.TypeOfShifts.Remove(typeOfShift);
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
