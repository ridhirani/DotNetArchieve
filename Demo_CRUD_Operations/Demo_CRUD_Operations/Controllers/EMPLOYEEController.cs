using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Demo_CRUD_Operations;

namespace Demo_CRUD_Operations.Controllers
{
    public class EMPLOYEEController : Controller
    {
        private AdventureWorks2017Entities db = new AdventureWorks2017Entities();

        // GET: EMPLOYEE_RIDHI_FIFTEENTH
        public ActionResult Index()
        {
            return View(db.EMPLOYEE_RIDHI_FIFTEENTH.ToList());
        }

        // GET: EMPLOYEE_RIDHI_FIFTEENTH/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EMPLOYEE_RIDHI_FIFTEENTH eMPLOYEE_RIDHI_FIFTEENTH = db.EMPLOYEE_RIDHI_FIFTEENTH.Find(id);
            if (eMPLOYEE_RIDHI_FIFTEENTH == null)
            {
                return HttpNotFound();
            }
            return View(eMPLOYEE_RIDHI_FIFTEENTH);
        }

        // GET: EMPLOYEE_RIDHI_FIFTEENTH/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EMPLOYEE_RIDHI_FIFTEENTH/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "EMPLOYEE_Id,FirstName,LastName,Address,EmailID")] EMPLOYEE_RIDHI_FIFTEENTH eMPLOYEE_RIDHI_FIFTEENTH)
        {
            if (ModelState.IsValid)
            {
                db.EMPLOYEE_RIDHI_FIFTEENTH.Add(eMPLOYEE_RIDHI_FIFTEENTH);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(eMPLOYEE_RIDHI_FIFTEENTH);
        }

        // GET: EMPLOYEE_RIDHI_FIFTEENTH/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EMPLOYEE_RIDHI_FIFTEENTH eMPLOYEE_RIDHI_FIFTEENTH = db.EMPLOYEE_RIDHI_FIFTEENTH.Find(id);
            if (eMPLOYEE_RIDHI_FIFTEENTH == null)
            {
                return HttpNotFound();
            }
            return View(eMPLOYEE_RIDHI_FIFTEENTH);
        }

        // POST: EMPLOYEE_RIDHI_FIFTEENTH/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "EMPLOYEE_Id,FirstName,LastName,Address,EmailID")] EMPLOYEE_RIDHI_FIFTEENTH eMPLOYEE_RIDHI_FIFTEENTH)
        {
            if (ModelState.IsValid)
            {
                db.Entry(eMPLOYEE_RIDHI_FIFTEENTH).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(eMPLOYEE_RIDHI_FIFTEENTH);
        }

        // GET: EMPLOYEE_RIDHI_FIFTEENTH/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EMPLOYEE_RIDHI_FIFTEENTH eMPLOYEE_RIDHI_FIFTEENTH = db.EMPLOYEE_RIDHI_FIFTEENTH.Find(id);
            if (eMPLOYEE_RIDHI_FIFTEENTH == null)
            {
                return HttpNotFound();
            }
            return View(eMPLOYEE_RIDHI_FIFTEENTH);
        }

        // POST: EMPLOYEE_RIDHI_FIFTEENTH/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            EMPLOYEE_RIDHI_FIFTEENTH eMPLOYEE_RIDHI_FIFTEENTH = db.EMPLOYEE_RIDHI_FIFTEENTH.Find(id);
            db.EMPLOYEE_RIDHI_FIFTEENTH.Remove(eMPLOYEE_RIDHI_FIFTEENTH);
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
