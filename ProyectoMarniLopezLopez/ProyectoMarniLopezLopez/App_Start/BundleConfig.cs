using System.Web;
using System.Web.Optimization;

namespace ProyectoMarniLopezLopez
{
    public class BundleConfig
    {
        
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862

        public static void RegisterBundles(BundleCollection bundles)
        {
            // Bundles for JS libraries

            //Core JS Libraries
            bundles.Add(new ScriptBundle("~/bundles/corejs").Include(
                        "~/Scripts/jquery-3.2.1.min.js", 
                        "~/Scripts/bootstrap.min.js",
                        "~/Scripts/material.min.js",
                        "~/Scripts/perfect-scrollbar.jquery.min.js"));

            //Additional Libraries
            bundles.Add(new ScriptBundle("~/bundles/addljs").Include(
            "~/Scripts/arrive.min.js",
            "~/Scripts/jquery.validate.min.js",
            "~/Scripts/moment.min.js",
            "~/Scripts/chartist.min.js",
            "~/Scripts/jquery.bootstrap-wizard.js",
            "~/Scripts/bootstrap-notify.js",
            "~/Scripts/bootstrap-datetimepicker.js",
            "~/Scripts/jquery-jvectormap.js",
            "~/Scripts/nouislider.min.js",
            "~/Scripts/jquery.select-bootstrap.js",
            "~/Scripts/jquery.datatables.js",
            "~/Scripts/sweetalert2.js",
            "~/Scripts/jasny-bootstrap.min.js",
            "~/Scripts/fullcalendar.min.js",
            "~/Scripts/jquery.tagsinput.js",
            "~/Scripts/material-dashboard.js",
            "~/Scripts/demo.js"));


            //Bundles for CSS
            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.min.css",
                      "~/Content/material-dashboard.css",
                      "~/Content/demo.css"));
        }
    }
}
