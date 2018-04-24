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
    public class FacturaController : Controller
    {
        private prj_marnylopezEntities1 db = new prj_marnylopezEntities1();

        // GET: Factura
        public ActionResult Index()
        {
            var srv_master = db.srv_master.Include(s => s.dtb_master).Include(s => s.pay_master).Include(s => s.sts_master).Include(s => s.usr_master).Include(s => s.dtb_svc_sts);
            return View(srv_master.ToList());
        }

        // GET: Factura/RealizarFacturacion/5
        public ActionResult RealizarFacturacion(int? pSrvId)
        {
            if (pSrvId == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            srv_master srv_master = db.srv_master.Find(pSrvId);
            if (srv_master == null)
            {
                return HttpNotFound();
            }
            ViewBag.pay_id = new SelectList(db.pay_master, "pay_id", "pay_dsc", srv_master.pay_id);

            return View(srv_master);
        }

        // POST: Factura/RealizarFacturacion/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult RealizarFacturacion([Bind(Include = "srv_id,pay_id")] srv_master srv_master)
        {
            if (ModelState.IsValid)
            {
                srv_master servicioActual = db.srv_master.Find(srv_master.srv_id);
                dtb_master mesaActual = db.dtb_master.Find(servicioActual.dtb_id);

                mesaActual.dtb_act_svc_id = 0; //Reiniciar el servicio asignado a la mesa actual
                mesaActual.dtb_svc_sts_id = 1; //Poner la mesa como libre
                servicioActual.sts_id = 4; //Poner el servicio en pagado

                db.Entry(mesaActual).State = EntityState.Modified;
                db.Entry(servicioActual).State = EntityState.Modified;
                db.SaveChanges();
            }
            return RedirectToAction("Index");
        }
    }
}
