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
    public class WorkShiftController : Controller
    {
        private TeleTimeTestContext db = new TeleTimeTestContext();

        // GET: WorkShift
        public ActionResult Index()
        {
            //var viewModel = new WorkShiftViewerModel();
            //viewModel.WorkShifts = db.WorkShifts.ToList();
            //viewModel.WorkShiftNames = db.WorkShiftNames.ToList();
            //viewModel.Times = db.Times.ToList();
            //viewModel.TypeOfShifts = db.TypeOfShifts.ToList();
            //viewModel.Persons = db.Persons.ToList();
            //return View(viewModel);
            return View(db.WorkShifts.ToList());
        }

        // GET: WorkShift/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            WorkShift workShift = db.WorkShifts.Find(id);
            if (workShift == null)
            {
                return HttpNotFound();
            }
            return View(workShift);
        }

        // GET: WorkShift/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: WorkShift/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "WorkShiftID,ShiftName")] WorkShift workShift)
        {
            if (ModelState.IsValid)
            {
                db.WorkShifts.Add(workShift);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(workShift);
        }

        // GET: WorkShift/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            WorkShift workShift = db.WorkShifts.Find(id);
            if (workShift == null)
            {
                return HttpNotFound();
            }
            return View(workShift);
        }

        // POST: WorkShift/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "WorkShiftID,ShiftName")] WorkShift workShift)
        {
            if (ModelState.IsValid)
            {
                db.Entry(workShift).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(workShift);
        }

        // GET: WorkShift/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            WorkShift workShift = db.WorkShifts.Find(id);
            if (workShift == null)
            {
                return HttpNotFound();
            }
            return View(workShift);
        }

        // POST: WorkShift/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            WorkShift workShift = db.WorkShifts.Find(id);
            db.WorkShifts.Remove(workShift);
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
