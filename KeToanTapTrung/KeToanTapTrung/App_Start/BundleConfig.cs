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

            bundles.Add(new StyleBundle("~/css/custom").Include(
                        "~/Content/flatlab/css/style.css",
                        "~/Content/flatlab/css/style-responsive.css",

                        "~/Content/Site.css"
                        ));


            bundles.Add(new ScriptBundle("~/js/common").Include(

                      "~/Content/flatlab/js/jquery.js",
                      "~/Content/flatlab/js/jquery-ui-1.9.2.custom.min.js",
                      "~/Content/flatlab/js/jquery-migrate-1.2.1.min.js",

                      "~/Scripts/modernizr-*",
                      "~/Content/flatlab/js/bootstrap.min.js",

                      "~/Content/flatlab/js/jquery.dcjqaccordion.2.7.js",
                      "~/Content/flatlab/js/jquery.scrollTo.min.js",
                      "~/Content/flatlab/js/jquery.nicescroll.js",

                      "~/Content/flatlab/js/respond.min.js",
                      "~/Content/flatlab/js/hover-dropdown.js",
                      "~/Content/flatlab/js/slidebars.min.js",
                      "~/Content/flatlab/js/jquery.tagsinput.js",

                      "~/Content/flatlab/assets/bootstrap-datepicker/js/bootstrap-datepicker.js",
                      "~/Content/flatlab/assets/select2/js/select2.min.js",
                      "~/Content/flatlab/assets/toastr-master/toastr.js",
                      "~/Content/flatlab/assets/summernote/dist/summernote.min.js"
                      ));

            bundles.Add(new ScriptBundle("~/js/plug-in").Include(
                        "~/Content/politespace/js/politespace.js",
                        //"~/Scripts/jquery.mask.js",
                        "~/Content/datatables/1.10.18/js/jquery.dataTables.min.js",
                        "~/Content/datatables/1.10.18/js/dataTables.bootstrap.min.js"
                        //"~/Content/datatables/rowgroup/1.0.3/js/dataTables.rowGroup.min.js"
                        ));

            bundles.Add(new ScriptBundle("~/js/custom").Include(
                        "~/Content/politespace/js/politespace-init.js",
                        "~/Scripts/moment.js",
                        "~/Content/flatlab/js/common-scripts.js",
                        "~/Scripts/main.js"
                        ));
        }
    }
}
