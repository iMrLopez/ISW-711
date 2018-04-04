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
            return Content($"Hello {pMesaAAbrir} Bienvenido a la apertura de la mesa {pMeseroApertura}");

            //TODO escribir la apertura de la mesa a la base de datos en srv_master y terminar con la redireccion a la pagina "OrderDtb" del usuario
        }

        // GET: OrderDtb -> Order Dinning Table
        public ActionResult OrderDtb(int pmesa, int psalonero)
        {
            return View(db.dtb_master.ToList());
        }

        // GET: PrtAccDtb -> Print Account Dinning Table
        public ActionResult PrtAccDtb(int pmesa)
        {
            return View(db.dtb_master.ToList());
        }

        // GET: ViwAccDtb -> View Account Dinning Table
        public ActionResult ViwAccDtb(int pmesa, int psalonero)
        {
            return View(db.dtb_master.ToList());
        }

    }
}
