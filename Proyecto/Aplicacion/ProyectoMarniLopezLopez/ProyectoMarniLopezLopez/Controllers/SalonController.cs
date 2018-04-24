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

        // GET: OpenDtb -> Open Dinning Table
        [HttpGet]
        public ActionResult OpenDtb(int pmesa)

        {
            ViewData["pmesa"] = pmesa;
            ViewData["plistaUsuarios"] = db.usr_master.ToList();
            return View();

        }

        // POST: OpenDtb -> Open Dinning Table
        [HttpPost]
        public ActionResult OpenDtb(string pMesaAAbrir, string pMeseroApertura)
        {

            //Create new service for this table
            srv_master srvActual = new srv_master { };
            srvActual.dtb_id = Convert.ToInt32(pMesaAAbrir);
            srvActual.sts_id = 2; //Cambiar el estado del servicio a Ocupado
            srvActual.srv_date = DateTime.Now;
            srvActual.usr_id = (pMeseroApertura);
            db.srv_master.Add(srvActual);
            db.SaveChanges();

            //Update dinning table status
            dtb_master dbse = db.dtb_master.Find(Convert.ToInt32(pMesaAAbrir));
            dbse.dtb_svc_sts_id = 2; // Cambiar estado de la mesa
            dbse.dtb_act_svc_id = srvActual.srv_id;
            db.Entry(dbse).State = EntityState.Modified;
            db.SaveChanges();




            //Redirect to OrderDtb action
            return RedirectToAction("OrderDtb", new { pSrv_id = srvActual.srv_id });
        }

        // GET: OrderDtb -> Order Dinning Table
        public ActionResult OrderDtb(string pSrv_id)
        {

            ViewBag.listaProductosEstaOrden = ViewBag.listaProductosEstaOrden = ObtieneProductosParaOrdenActual(Convert.ToInt32(pSrv_id)); //Obtiene lista con los productos de la orden actual
            ViewBag.prd_id = new SelectList(db.prd_master, "prd_id", "prd_shdsc");
            ViewBag.srv_id = pSrv_id;
            ViewBag.masterEstaOrden = db.srv_master.Find(Convert.ToInt32(pSrv_id));

            return View();
        }

        // POST: OrderDtb -> Order Dinning Table
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult OrderDtb([Bind(Include = "srv_id,srv_qty,srv_notes,prd_id")] srv_detail srv_detail)
        {
            if (ModelState.IsValid)
            {
                //Agregar la nueva linea de detalle del servicio
                db.srv_detail.Add(srv_detail);
  
                //Proceder a actualizar el master del servicio
                srv_master masterTemporal = db.srv_master.Find(srv_detail.srv_id);
                masterTemporal.srv_total = masterTemporal.srv_total + (srv_detail.srv_qty * db.prd_master.Find(srv_detail.prd_id).prd_price);
                db.Entry(masterTemporal).State = EntityState.Modified;

                //Guardar info a la bdatos
                db.SaveChanges();

            }

            return RedirectToAction("OrderDtb", new { pSrv_id = srv_detail.srv_id });
        }


        // GET: PrtAccDtb -> Print Account Dinning Table Update data
        public ActionResult PrtAccDtb(int pSrv_id)
        {

            srv_master servicioCabecera = db.srv_master.Find(pSrv_id);
            dtb_master mesaCabecera = db.dtb_master.Find(servicioCabecera.dtb_id);

            //Actualizar los estados de la mesa en la base de datos
            servicioCabecera.sts_id = 3;
            mesaCabecera.dtb_svc_sts_id = 3;

            db.Entry(servicioCabecera).State = EntityState.Modified;
            db.Entry(mesaCabecera).State = EntityState.Modified;
            
            //Guardar informacion en la base de datos
            db.SaveChanges();

            //Pasar variables a la vista
            ViewBag.servicioCabecera = servicioCabecera;
            ViewBag.servicioDetalle = ObtieneProductosParaOrdenActual(pSrv_id);
            ViewBag.mesaCabecera = mesaCabecera;

            return View();
        }

        

        // GET: ViwAccDtb -> View Account Dinning Table
        public ActionResult ViewAccDtb(int pSrv_id)
        {
            ViewBag.listaProductosEstaOrden = ObtieneProductosParaOrdenActual(pSrv_id);
            ViewBag.masterEstaOrden = db.srv_master.Find(Convert.ToInt32(pSrv_id));

            return View();
            
        }


        //Utilizado para obtener una lista de los productos para la orden pasada por parametro
        private List<srv_detail> ObtieneProductosParaOrdenActual(int pSrv_id) {

            List<srv_detail> listaProductosEstaOrden = new List<srv_detail>();
            List<srv_detail> listaTodosProductosDeOrdenes = db.srv_detail.ToList(); //Optimize this query

            foreach (srv_detail item in listaTodosProductosDeOrdenes) //This should be done in db side TODO try to optimize this
            {
                if (item.srv_id == Convert.ToInt32(pSrv_id))
                {
                    listaProductosEstaOrden.Add(item);
                }
            }

            return listaProductosEstaOrden;
        }

    }
}
