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
    public class ProductController : Controller
    {
        private prj_marnylopezEntities1 db = new prj_marnylopezEntities1();

        // GET: Product
        public ActionResult Index()
        {
            var prd_master = db.prd_master.Include(p => p.cat_master).Include(p => p.sts_master);
            return View(prd_master.ToList());
        }

        // GET: Product/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            prd_master prd_master = db.prd_master.Find(id);
            if (prd_master == null)
            {
                return HttpNotFound();
            }
            return View(prd_master);
        }

        // GET: Product/Create
        public ActionResult Create()
        {
            ViewBag.cat_id = new SelectList(db.cat_master, "cat_id", "cat_dsc");
            ViewBag.sts_id = new SelectList(db.sts_master, "sts_id", "sts_dsc");
            return View();
        }

        // POST: Product/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "prd_id,prd_shdsc,prd_lgdsc,prd_price,cat_id,sts_id")] prd_master prd_master)
        {
            if (ModelState.IsValid)
            {
                db.prd_master.Add(prd_master);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.cat_id = new SelectList(db.cat_master, "cat_id", "cat_dsc", prd_master.cat_id);
            ViewBag.sts_id = new SelectList(db.sts_master, "sts_id", "sts_dsc", prd_master.sts_id);
            return View(prd_master);
        }

        // GET: Product/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            prd_master prd_master = db.prd_master.Find(id);
            if (prd_master == null)
            {
                return HttpNotFound();
            }
            ViewBag.cat_id = new SelectList(db.cat_master, "cat_id", "cat_dsc", prd_master.cat_id);
            ViewBag.sts_id = new SelectList(db.sts_master, "sts_id", "sts_dsc", prd_master.sts_id);
            return View(prd_master);
        }

        // POST: Product/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "prd_id,prd_shdsc,prd_lgdsc,prd_price,cat_id,sts_id")] prd_master prd_master)
        {
            if (ModelState.IsValid)
            {
                db.Entry(prd_master).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.cat_id = new SelectList(db.cat_master, "cat_id", "cat_dsc", prd_master.cat_id);
            ViewBag.sts_id = new SelectList(db.sts_master, "sts_id", "sts_dsc", prd_master.sts_id);
            return View(prd_master);
        }

        // GET: Product/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            prd_master prd_master = db.prd_master.Find(id);
            if (prd_master == null)
            {
                return HttpNotFound();
            }
            return View(prd_master);
        }

        // POST: Product/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            prd_master prd_master = db.prd_master.Find(id);
            db.prd_master.Remove(prd_master);
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
