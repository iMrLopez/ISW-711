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
                return RedirectToAction(Session["UserIndex"].ToString(), "Home", null);
            }
            else {
                return RedirectToAction("Index");
            }
        }


        //GET: Logout (logs the user out of the system
        public ActionResult Logout() {
            this.unsetupSession();
            return RedirectToAction("Index", "Login");

        }

        // this verifies if the user exists in the database and then verifies its password
        private bool doLogin(usr_master pusr_master)
        {
            usr_master usr_master = db.usr_master.Find(pusr_master.usr_id);
            if (usr_master == null || usr_master.usr_password != pusr_master.usr_password)
                return false;
            this.setupSession(usr_master);
            return true;
        }

        //This saves the actual user object inside of the session variable, to use it in the verification and in the shown of the user menu
        private void setupSession(usr_master pusr_master) {
            try
            {
                if (pusr_master != null)
                {
                    Session["User"] = pusr_master;
                    Session["UserName"] = pusr_master.usr_id;
                    Session["UserType"] = pusr_master.rol_id;

                    switch (pusr_master.rol_id)
                    {
                        case 1:
                            Session["UserIndex"] = "IndexAdmin";
                            break;
                        case 2:
                            Session["UserIndex"] = "IndexWaiter";
                            break;
                        default:
                            break;

                    }

                    
                    //Response.Redirect("Inicio.aspx");
                }
            }
            catch (Exception a)
            {
                Console.Write(a);
            }
        }

        private void unsetupSession()
        {
            Session["User"] = null;
            Session["UserType"] = null;
            Session["UserIndex"] = null;
                    
        }
    }
}
