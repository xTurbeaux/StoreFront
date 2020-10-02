using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using AAronsAmmoShack.DATA.EF;

namespace AAronsAmmoShack.UI.MVC.Controllers
{
    public class AmmosController : Controller
    {
        private DBAmmoShackEntities db = new DBAmmoShackEntities();

        // GET: Ammos
        public ActionResult Index()
        {
            var ammos = db.Ammos.Include(a => a.Caliber).Include(a => a.Damage).Include(a => a.Manufacturer).Include(a => a.RelatedFirearm);
            return View(ammos.ToList());
        }

        // GET: Ammos/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ammos ammos = db.Ammos.Find(id);
            if (ammos == null)
            {
                return HttpNotFound();
            }
            return View(ammos);
        }

        // GET: Ammos/Create
        public ActionResult Create()
        {
            ViewBag.CaliberID = new SelectList(db.Calibers1, "CaliberID", "CaliberName");
            ViewBag.DamageID = new SelectList(db.Damages1, "DamageID", "DamageID");
            ViewBag.ManufacturerID = new SelectList(db.Manufacturers1, "ManufacturerID", "City");
            ViewBag.RFID = new SelectList(db.RelatedFirearms1, "RFID", "FamilyName");
            return View();
        }

        // POST: Ammos/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "AmmoID,AmmoName,AmmoDescription,IsAvailable,Price,IsTracer,IsSubsonic,MuzzleVelocity,ProductImage,CaliberID,RFID,DamageID,ManufacturerID")] Ammos ammos)
        {
            if (ModelState.IsValid)
            {
                db.Ammos.Add(ammos);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.CaliberID = new SelectList(db.Calibers1, "CaliberID", "CaliberName", ammos.CaliberID);
            ViewBag.DamageID = new SelectList(db.Damages1, "DamageID", "DamageID", ammos.DamageID);
            ViewBag.ManufacturerID = new SelectList(db.Manufacturers1, "ManufacturerID", "City", ammos.ManufacturerID);
            ViewBag.RFID = new SelectList(db.RelatedFirearms1, "RFID", "FamilyName", ammos.RFID);
            return View(ammos);
        }

        // GET: Ammos/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ammos ammos = db.Ammos.Find(id);
            if (ammos == null)
            {
                return HttpNotFound();
            }
            ViewBag.CaliberID = new SelectList(db.Calibers1, "CaliberID", "CaliberName", ammos.CaliberID);
            ViewBag.DamageID = new SelectList(db.Damages1, "DamageID", "DamageID", ammos.DamageID);
            ViewBag.ManufacturerID = new SelectList(db.Manufacturers1, "ManufacturerID", "City", ammos.ManufacturerID);
            ViewBag.RFID = new SelectList(db.RelatedFirearms1, "RFID", "FamilyName", ammos.RFID);
            return View(ammos);
        }

        // POST: Ammos/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "AmmoID,AmmoName,AmmoDescription,IsAvailable,Price,IsTracer,IsSubsonic,MuzzleVelocity,ProductImage,CaliberID,RFID,DamageID,ManufacturerID")] Ammos ammos)
        {
            if (ModelState.IsValid)
            {
                db.Entry(ammos).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.CaliberID = new SelectList(db.Calibers1, "CaliberID", "CaliberName", ammos.CaliberID);
            ViewBag.DamageID = new SelectList(db.Damages1, "DamageID", "DamageID", ammos.DamageID);
            ViewBag.ManufacturerID = new SelectList(db.Manufacturers1, "ManufacturerID", "City", ammos.ManufacturerID);
            ViewBag.RFID = new SelectList(db.RelatedFirearms1, "RFID", "FamilyName", ammos.RFID);
            return View(ammos);
        }

        // GET: Ammos/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ammos ammos = db.Ammos.Find(id);
            if (ammos == null)
            {
                return HttpNotFound();
            }
            return View(ammos);
        }

        // POST: Ammos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Ammos ammos = db.Ammos.Find(id);
            db.Ammos.Remove(ammos);
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
