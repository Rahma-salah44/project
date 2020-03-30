using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Pharmacy.Models;

namespace Pharmacy.Controllers
{
    public class deletepharmacistsController : Controller
    {
        private Pharmacy_DBEntities6 db = new Pharmacy_DBEntities6();

        // GET: deletepharmacists
        public ActionResult Index()
        {
            return View(db.pharmacists.ToList());
        }

        // GET: deletepharmacists/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            pharmacist pharmacist = db.pharmacists.Find(id);
            if (pharmacist == null)
            {
                return HttpNotFound();
            }
            return View(pharmacist);
        }

        // GET: deletepharmacists/Create
        //public ActionResult Create()
        //{
        //    return View();
        //}

        //// POST: deletepharmacists/Create
        //// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        //// more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Create([Bind(Include = "UserID,FirstName,LastName,EmailID,DateOfBirth,Password,IsEmailVertified,ActivationCode")] pharmacist pharmacist)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        db.pharmacists.Add(pharmacist);
        //        db.SaveChanges();
        //        return RedirectToAction("Index");
        //    }

        //    return View(pharmacist);
        //}

        //// GET: deletepharmacists/Edit/5
        //public ActionResult Edit(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    pharmacist pharmacist = db.pharmacists.Find(id);
        //    if (pharmacist == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(pharmacist);
        //}

        //// POST: deletepharmacists/Edit/5
        //// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        //// more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Edit([Bind(Include = "UserID,FirstName,LastName,EmailID,DateOfBirth,Password,IsEmailVertified,ActivationCode")] pharmacist pharmacist)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        db.Entry(pharmacist).State = EntityState.Modified;
        //        db.SaveChanges();
        //        return RedirectToAction("Index");
        //    }
        //    return View(pharmacist);
        //}

        //// GET: deletepharmacists/Delete/5
        //public ActionResult Delete(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    pharmacist pharmacist = db.pharmacists.Find(id);
        //    if (pharmacist == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(pharmacist);
        //}

        // POST: deletepharmacists/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            pharmacist pharmacist = db.pharmacists.Find(id);
            db.pharmacists.Remove(pharmacist);
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
