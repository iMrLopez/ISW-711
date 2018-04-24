using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Examen2WilberthMolina
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            /*Algo en la linea 20 podría cambiarse para que ingrese directo al listado*/
            routes.MapRoute(
                 name: "Default",
               url: "{controller}/{action}/{id}",
               defaults: new { controller = "Paquete", action = "Index", id = UrlParameter.Optional }
            );
           /*Abajo iria un MapRoute de Paquete*/





        }
    }
}
