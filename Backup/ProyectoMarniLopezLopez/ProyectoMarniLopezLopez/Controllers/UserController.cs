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
    public class UserController : Controller
    {
        private prj_marnylopezEntities1 db = new prj_marnylopezEntities1();

        // GET: User
        public ActionResult Index()
        {
            var usr_master = db.usr_master.Include(u => u.rol_master).Include(u => u.sts_master);
            return View(usr_master.ToList());
        }

        // GET: User/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            usr_master usr_master = db.usr_master.Find(id);
            if (usr_master == null)
            {
                return HttpNotFound();
            }
            return View(usr_master);
        }

        // GET: User/Create
        public ActionResult Create()
        {
            ViewBag.rol_id = new SelectList(db.rol_master, "rol_id", "rol_dsc");
            ViewBag.sts_id = new SelectList(db.sts_master, "sts_id", "sts_dsc");
            return View();
        }

        // POST: User/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "usr_id,usr_password,sts_id,rol_id")] usr_master usr_master)
        {
            if (ModelState.IsValid)
            {
                db.usr_master.Add(usr_master);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.rol_id = new SelectList(db.rol_master, "rol_id", "rol_dsc", usr_master.rol_id);
            ViewBag.sts_id = new SelectList(db.sts_master, "sts_id", "sts_dsc", usr_master.sts_id);
            return View(usr_master);
        }

        // GET: User/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            usr_master usr_master = db.usr_master.Find(id);
            if (usr_master == null)
            {
                return HttpNotFound();
            }
            ViewBag.rol_id = new SelectList(db.rol_master, "rol_id", "rol_dsc", usr_master.rol_id);
            ViewBag.sts_id = new SelectList(db.sts_master, "sts_id", "sts_dsc", usr_master.sts_id);
            return View(usr_master);
        }

        // POST: User/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "usr_id,usr_password,sts_id,rol_id")] usr_master usr_master)
        {
            if (ModelState.IsValid)
            {
                db.Entry(usr_master).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.rol_id = new SelectList(db.rol_master, "rol_id", "rol_dsc", usr_master.rol_id);
            ViewBag.sts_id = new SelectList(db.sts_master, "sts_id", "sts_dsc", usr_master.sts_id);
            return View(usr_master);
        }

        // GET: User/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            usr_master usr_master = db.usr_master.Find(id);
            if (usr_master == null)
            {
                return HttpNotFound();
            }
            return View(usr_master);
        }

        // POST: User/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            usr_master usr_master = db.usr_master.Find(id);
            db.usr_master.Remove(usr_master);
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
