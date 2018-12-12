using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using DataAcquisitionSystem.Models;

namespace DataAcquisitionSystem.Controllers
{
    public class CipDataCollectionsController : Controller
    {
        private DataAcquisitionSystemContext db = new DataAcquisitionSystemContext();

        // GET: CipDataCollections
        public ActionResult Index()
        {
            return View(db.CipDataCollections.ToList());
        }

        // GET: CipDataCollections/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CipDataCollection cipDataCollection = db.CipDataCollections.Find(id);
            if (cipDataCollection == null)
            {
                return HttpNotFound();
            }
            return View(cipDataCollection);
        }

        // GET: CipDataCollections/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CipDataCollections/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,DateTransacted,DateCollected,DateCreated,Fit1FlowRate,Lt1Gallons,Lt2Gallons,Pt1Pressure,Pt2Pressure,P1Speed,P2Speed,Tt1Temperature,Tt2Temperature,Tt3Temperature")] CipDataCollection cipDataCollection)
        {
            if (ModelState.IsValid)
            {
                db.CipDataCollections.Add(cipDataCollection);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(cipDataCollection);
        }

        // GET: CipDataCollections/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CipDataCollection cipDataCollection = db.CipDataCollections.Find(id);
            if (cipDataCollection == null)
            {
                return HttpNotFound();
            }
            return View(cipDataCollection);
        }

        // POST: CipDataCollections/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,DateTransacted,DateCollected,DateCreated,Fit1FlowRate,Lt1Gallons,Lt2Gallons,Pt1Pressure,Pt2Pressure,P1Speed,P2Speed,Tt1Temperature,Tt2Temperature,Tt3Temperature")] CipDataCollection cipDataCollection)
        {
            if (ModelState.IsValid)
            {
                db.Entry(cipDataCollection).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(cipDataCollection);
        }

        // GET: CipDataCollections/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CipDataCollection cipDataCollection = db.CipDataCollections.Find(id);
            if (cipDataCollection == null)
            {
                return HttpNotFound();
            }
            return View(cipDataCollection);
        }

        // POST: CipDataCollections/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CipDataCollection cipDataCollection = db.CipDataCollections.Find(id);
            db.CipDataCollections.Remove(cipDataCollection);
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
