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
    public class LoginController : Controller
    {
        private prj_marnylopezEntities1 db = new prj_marnylopezEntities1();

        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        // POST: Login/Index
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index([Bind(Include = "usr_id,usr_password")] usr_master usr_master)
        {
            if (doLogin(usr_master))
            {
                return RedirectToAction("Index", "Home", null);
            }
            else {
                return RedirectToAction("Index");
            }
        }

        // this verifies if the user exists in the database and then verifies its password
        private bool doLogin(usr_master pusr_master)
        {
            usr_master usr_master = db.usr_master.Find(pusr_master.usr_id);
            if (usr_master == null || usr_master.usr_password != pusr_master.usr_password)
                return false;
            return true;
        }
        
    }
}
