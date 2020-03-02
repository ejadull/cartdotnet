using System.Web;
using System.Web.Optimization;

namespace UI.Cart
{
    public class BundleConfig
    {
        // Para obtener más información sobre las uniones, visite https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Utilice la versión de desarrollo de Modernizr para desarrollar y obtener información. De este modo, estará
            // para la producción, use la herramienta de compilación disponible en https://modernizr.com para seleccionar solo las pruebas que necesite.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));


            bundles.Add(new ScriptBundle("~/bundles/paneljs").Include(
                      "~/Content/admin-lte/plugins/jquery/jquery.min.js",
                      "~/Content/admin-lte/plugins/jquery-ui/jquery-ui.min.js",
                      "~/Content/admin-lte/plugins/bootstrap/js/bootstrap.bundle.min.js",
                      "~/Content/admin-lte/plugins/chart.js/Chart.min.js",
                      "~/Content/admin-lte/plugins/sparklines/sparkline.js",
                      "~/Content/admin-lte/plugins/jqvmap/jquery.vmap.min.js",
                      "~/Content/admin-lte/plugins/jqvmap/maps/jquery.vmap.usa.js",
                      "~/Content/admin-lte/plugins/jquery-knob/jquery.knob.min.js",
                      "~/Content/admin-lte/plugins/moment/moment.min.js",
                      "~/Content/admin-lte/plugins/daterangepicker/daterangepicker.js",
                      "~/Content/admin-lte/plugins/tempusdominus-bootstrap-4/js/tempusdominus-bootstrap-4.min.js",
                      "~/Content/admin-lte/plugins/summernote/summernote-bs4.min.js",
                      "~/Content/admin-lte/plugins/overlayScrollbars/js/jquery.overlayScrollbars.min.js",
                      "~/Content/admin-lte/dist/js/adminlte.js",
                      "~/Scripts/panel/panel.js"

                      ));


            bundles.Add(new StyleBundle("~/bundles/panelcss").Include(
                      "~/Content/admin-lte/plugins/fontawesome-free/css/all.min.css",
                      "~/Content/admin-lte/plugins/tempusdominus-bootstrap-4/css/tempusdominus-bootstrap-4.min.css",
                      "~/Content/admin-lte/plugins/icheck-bootstrap/icheck-bootstrap.min.css",
                      "~/Content/admin-lte/plugins/jqvmap/jqvmap.min.css",
                      "~/Content/admin-lte/dist/css/adminlte.min.css",
                      "~/Content/admin-lte/plugins/overlayScrollbars/css/OverlayScrollbars.min.css",
                      "~/Content/admin-lte/plugins/daterangepicker/daterangepicker.css",
                      "~/Content/admin-lte/plugins/summernote/summernote-bs4.css"));


            bundles.Add(new ScriptBundle("~/bundles/datatablejs").Include(
                      "~/Content/admin-lte/plugins/datatables/jquery.dataTables.js",
                      "~/Content/admin-lte/plugins/datatables-bs4/js/dataTables.bootstrap4.js",
                      "~/Scripts/Spanish.js"
                      ));
            bundles.Add(new StyleBundle("~/bundles/datatablecss").Include(
                      "~/Content/admin-lte/plugins/plugins/datatables-bs4/css/dataTables.bootstrap4.css"
                      ));

        }
    }
}
