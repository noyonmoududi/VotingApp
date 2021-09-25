using System.Web;
using System.Web.Optimization;

namespace VotingApp
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js"));

            bundles.Add(new ScriptBundle("~/Content/Admin/js").Include(
               "~/Content/Admin/plugins/jquery/jquery.min.js",
               "~/Content/Admin/plugins/bootstrap/js/bootstrap.bundle.min.js",
               "~/Content/Admin/plugins/daterangepicker/daterangepicker.js",
               //data table
               "~/Content/Admin/plugins/datatables/jquery.dataTables.min.js",
               "~/Content/Admin/plugins/datatables-bs4/js/dataTables.bootstrap4.min.js",
               "~/Content/Admin/plugins/datatables-responsive/js/dataTables.responsive.min.js",
               "~/Content/Admin/plugins/datatables-responsive/js/responsive.bootstrap4.min.js",
               //end
               "~/Content/Admin/plugins/overlayScrollbars/js/jquery.overlayScrollbars.min.js",
               "~/Content/Admin/dist/js/adminlte.js"
               ));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));

            bundles.Add(new StyleBundle("~/Content/Admin/css").Include(
                     "~/Content/Admin/plugins/fontawesome-free/css/all.min.css",
                     "~/Content/Admin/plugins/fontawesome-free/css/fontawesome.min.css",
                     "~/Content/Admin/plugins/daterangepicker/daterangepicker.css",
                     //data Table
                     "~/Content/Admin/plugins/datatables-bs4/css/dataTables.bootstrap4.min.css",
                     "~/Content/Admin/plugins/datatables-responsive/css/responsive.bootstrap4.min.css",
                     "~/Content/Admin/plugins/overlayScrollbars/css/OverlayScrollbars.min.css",
                     //end
                     "~/Content/Admin/dist/css/adminlte.min.css.map",
                     "~/Content/Admin/dist/css/adminlte.min.css"

                   ));
        }
    }
}
