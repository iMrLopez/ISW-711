using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Practica2MarniLopez.Models;

namespace Practica2MarniLopez.Controllers
{
    public class ordenController : Controller
    {
        private clase12Entities db = new clase12Entities();

        // GET: orden
        public ActionResult Index()
        {
            var ordenDesayunoes = db.ordenDesayunoes.Include(o => o.desayuno);
            return View(ordenDesayunoes.ToList());
        }

        // GET: orden/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                //return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
                return RedirectToAction("Index");
            }
            ordenDesayuno ordenDesayuno = db.ordenDesayunoes.Find(id);
            if (ordenDesayuno == null)
            {
                return HttpNotFound();
            }
            return View(ordenDesayuno);
        }

        // GET: orden/Create
        public ActionResult Create()
        {
            ViewBag.idDesayuno = new SelectList(db.desayunoes, "idDesayuno", "nombre");
            return View();
        }

        // POST: orden/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "idOrdenDesayuno,nombre,fecha,idDesayuno,cantidad")] ordenDesayuno ordenDesayuno)
        {
            if (ModelState.IsValid)
            {
                //Calculo del total nuevo
                ordenDesayuno = calcularNuevoTotal(ordenDesayuno);


                db.ordenDesayunoes.Add(ordenDesayuno);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.idDesayuno = new SelectList(db.desayunoes, "idDesayuno", "nombre", ordenDesayuno.idDesayuno);
            return View(ordenDesayuno);
        }

        // GET: orden/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                //return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
                return RedirectToAction("Index");
            }
            ordenDesayuno ordenDesayuno = db.ordenDesayunoes.Find(id);
            if (ordenDesayuno == null)
            {
                return HttpNotFound();
            }
            ViewBag.idDesayuno = new SelectList(db.desayunoes, "idDesayuno", "nombre", ordenDesayuno.idDesayuno);
            return View(ordenDesayuno);
        }

        // POST: orden/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "idOrdenDesayuno,nombre,fecha,idDesayuno,cantidad")] ordenDesayuno ordenDesayuno)
        {
            if (ModelState.IsValid)
            {
                //Calculo del total nuevo
                ordenDesayuno = calcularNuevoTotal(ordenDesayuno);

                db.Entry(ordenDesayuno).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.idDesayuno = new SelectList(db.desayunoes, "idDesayuno", "nombre", ordenDesayuno.idDesayuno);
            return View(ordenDesayuno);
        }


        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }


        private ordenDesayuno calcularNuevoTotal(ordenDesayuno pOrden) {
            //Calculo del total nuevo

            pOrden.total = pOrden.cantidad * db.desayunoes.Find(pOrden.idDesayuno).precio9;

            return pOrden;
        }

    }
}
