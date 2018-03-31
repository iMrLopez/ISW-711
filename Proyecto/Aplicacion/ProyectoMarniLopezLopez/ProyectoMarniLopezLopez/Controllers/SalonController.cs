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
        public ActionResult OpenDtb(int pmesa, int psalonero)
        {
            return View(db.dtb_master.ToList());
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
