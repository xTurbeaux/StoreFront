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
    public class ManufacturersController : Controller
    {
        private DBAmmoShackEntities db = new DBAmmoShackEntities();

        // GET: Manufacturers
        public ActionResult Index()
        {
            return View(db.Manufacturers1.ToList());
        }

        // GET: Manufacturers/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Manufacturers manufacturers = db.Manufacturers1.Find(id);
            if (manufacturers == null)
            {
                return HttpNotFound();
            }
            return View(manufacturers);
        }

        // GET: Manufacturers/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Manufacturers/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ManufacturerID,City,State,Country,Name")] Manufacturers manufacturers)
        {
            if (ModelState.IsValid)
            {
                db.Manufacturers1.Add(manufacturers);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(manufacturers);
        }

        // GET: Manufacturers/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Manufacturers manufacturers = db.Manufacturers1.Find(id);
            if (manufacturers == null)
            {
                return HttpNotFound();
            }
            return View(manufacturers);
        }

        // POST: Manufacturers/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ManufacturerID,City,State,Country,Name")] Manufacturers manufacturers)
        {
            if (ModelState.IsValid)
            {
                db.Entry(manufacturers).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(manufacturers);
        }

        // GET: Manufacturers/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Manufacturers manufacturers = db.Manufacturers1.Find(id);
            if (manufacturers == null)
            {
                return HttpNotFound();
            }
            return View(manufacturers);
        }

        // POST: Manufacturers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Manufacturers manufacturers = db.Manufacturers1.Find(id);
            db.Manufacturers1.Remove(manufacturers);
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
