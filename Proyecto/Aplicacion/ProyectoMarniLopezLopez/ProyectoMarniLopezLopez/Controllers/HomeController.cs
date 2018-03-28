using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProyectoMarniLopezLopez.Controllers
{
    public class HomeController : Controller
    {

        // GET: Home
        public ActionResult IndexAdmin(){
            return View();
        }

        public ActionResult IndexWaiter() {
            return View();
        }


        // Used to verify what Home controller we have to show to the user
        private String getUserIndex()
        {
            switch (int.Parse(Session["UserType"].ToString()))
            {
                case 1:
                    return "IndexAdmin";
                case 2:
                    return "IndexWaiter";
                default:
                    return "vacio";
            }
        }



    }
}