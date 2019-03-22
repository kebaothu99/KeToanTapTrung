using System.Web;
using System.Web.Optimization;

namespace KeToanTapTrung
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new StyleBundle("~/css/common").Include(
                       "~/Content/flatlab/css/bootstrap.min.css",
                       "~/Content/flatlab/css/bootstrap-reset.css",
                       "~/Content/flatlab/assets/font-awesome/css/font-awesome.css",
                       "~/Content/flatlab/css/jquery.steps.css",
                       "~/Content/flatlab/assets/bootstrap-datepicker/css/datepicker.css",
                       "~/Content/flatlab/assets/select2/css/select2.min.css",
                       "~/Content/flatlab/assets/toastr-master/toastr.css",
                       "~/Content/flatlab/assets/summernote/dist/summernote.css",
                       "~/Content/flatlab/css/tasks.css"
                       ));


            bundles.Add(new StyleBundle("~/css/plug-in").Include(
                       "~/Content/politespace/css/politespace.css",
                       "~/Content/datatables/1.10.18/css/dataTables.bootstrap.min.css"
                       //"~/Content/datatables/rowgroup/1.0.3/css/rowGroup.bootstrap.min.css"
                       //"~/Content/flatlab/assets/data-tables/DT_bootstrap.css"
                       ));

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

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));
        }
    }
}
