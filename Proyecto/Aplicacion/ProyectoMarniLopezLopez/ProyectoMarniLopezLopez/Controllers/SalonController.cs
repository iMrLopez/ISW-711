using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ProyectoMarniLopezLopez.Models;

namespace ProyectoMarniLopezLopez.Controllers
{
    public class SalonController : Controller
    {
        private prj_marnylopezEntities1 db = new prj_marnylopezEntities1();

        // GET: Salon
        public ActionResult Index()
        {
            return View(db.dtb_master.ToList());
        }

        // GET: Salon/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            dtb_master dtb_master = db.dtb_master.Find(id);
            if (dtb_master == null)
            {
                return HttpNotFound();
            }
            return View(dtb_master);
        }

        // GET: Salon/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Salon/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "dtb_id,dtb_status,dtb_descr")] dtb_master dtb_master)
        {
            if (ModelState.IsValid)
            {
                db.dtb_master.Add(dtb_master);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(dtb_master);
        }

        // GET: Salon/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            dtb_master dtb_master = db.dtb_master.Find(id);
            if (dtb_master == null)
            {
                return HttpNotFound();
            }
            return View(dtb_master);
        }

        // POST: Salon/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "dtb_id,dtb_status,dtb_descr")] dtb_master dtb_master)
        {
            if (ModelState.IsValid)
            {
                db.Entry(dtb_master).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(dtb_master);
        }

        // GET: Salon/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            dtb_master dtb_master = db.dtb_master.Find(id);
            if (dtb_master == null)
            {
                return HttpNotFound();
            }
            return View(dtb_master);
        }

        // POST: Salon/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            dtb_master dtb_master = db.dtb_master.Find(id);
            db.dtb_master.Remove(dtb_master);
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
