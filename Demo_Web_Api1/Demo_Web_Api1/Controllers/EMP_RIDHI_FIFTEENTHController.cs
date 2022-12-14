using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Demo_Web_Api1.Models;

namespace Demo_Web_Api1.Controllers
{
    public class EMP_RIDHI_FIFTEENTHController : Controller
    {
        private Freshers_Training2022Entities1 db = new Freshers_Training2022Entities1();

        // GET: EMP_RIDHI_FIFTEENTH
        public ActionResult Index()
        {
            return View(db.EMP_RIDHI_FIFTEENTH.ToList());
        }

        // GET: EMP_RIDHI_FIFTEENTH/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EMP_RIDHI_FIFTEENTH eMP_RIDHI_FIFTEENTH = db.EMP_RIDHI_FIFTEENTH.Find(id);
            if (eMP_RIDHI_FIFTEENTH == null)
            {
                return HttpNotFound();
            }
            return View(eMP_RIDHI_FIFTEENTH);
        }

        // GET: EMP_RIDHI_FIFTEENTH/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EMP_RIDHI_FIFTEENTH/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "EMPId,FirstName,LastName")] EMP_RIDHI_FIFTEENTH eMP_RIDHI_FIFTEENTH)
        {
            if (ModelState.IsValid)
            {
                db.EMP_RIDHI_FIFTEENTH.Add(eMP_RIDHI_FIFTEENTH);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(eMP_RIDHI_FIFTEENTH);
        }

        // GET: EMP_RIDHI_FIFTEENTH/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EMP_RIDHI_FIFTEENTH eMP_RIDHI_FIFTEENTH = db.EMP_RIDHI_FIFTEENTH.Find(id);
            if (eMP_RIDHI_FIFTEENTH == null)
            {
                return HttpNotFound();
            }
            return View(eMP_RIDHI_FIFTEENTH);
        }

        // POST: EMP_RIDHI_FIFTEENTH/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "EMPId,FirstName,LastName")] EMP_RIDHI_FIFTEENTH eMP_RIDHI_FIFTEENTH)
        {
            if (ModelState.IsValid)
            {
                db.Entry(eMP_RIDHI_FIFTEENTH).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(eMP_RIDHI_FIFTEENTH);
        }

        // GET: EMP_RIDHI_FIFTEENTH/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EMP_RIDHI_FIFTEENTH eMP_RIDHI_FIFTEENTH = db.EMP_RIDHI_FIFTEENTH.Find(id);
            if (eMP_RIDHI_FIFTEENTH == null)
            {
                return HttpNotFound();
            }
            return View(eMP_RIDHI_FIFTEENTH);
        }

        // POST: EMP_RIDHI_FIFTEENTH/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            EMP_RIDHI_FIFTEENTH eMP_RIDHI_FIFTEENTH = db.EMP_RIDHI_FIFTEENTH.Find(id);
            db.EMP_RIDHI_FIFTEENTH.Remove(eMP_RIDHI_FIFTEENTH);
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

//craete a project then add models and controllers 