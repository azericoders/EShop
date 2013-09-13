using System.Web;
using System.Web.Optimization;

namespace EShop.Web
{
    public class BundleConfig
    {
        // For more information on Bundling, visit http://go.microsoft.com/fwlink/?LinkId=254725
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryui").Include(
                        "~/Scripts/jquery-ui-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.unobtrusive*",
                        "~/Scripts/jquery.validate*"));
            bundles.Add(new ScriptBundle("~/adminBundles/jquery")
                .Include("~/Scripts/libryjs/jquery-1.7.2.min.js",
                "~/Scripts/libryjs/jquery-ui-1.8.21.custom.min.js",
                "~/Scripts/libryjs/bootstrap-transition.js",
                "~/Scripts/libryjs/bootstrap-alert.js",
                "~/Scripts/libryjs/bootstrap-modal.js",
                "~/Scripts/libryjs/bootstrap-dropdown.js",
                "~/Scripts/libryjs/bootstrap-scrollspy.js",
                "~/Scripts/libryjs/bootstrap-tab.js",
                "~/Scripts/libryjs/bootstrap-tooltip.js",
                "~/Scripts/libryjs/bootstrap-popover.js",
                "~/Scripts/libryjs/bootstrap-button.js",
                "~/Scripts/libryjs/bootstrap-collapse.js",
                "~/Scripts/libryjs/bootstrap-carousel.js",
                "~/Scripts/libryjs/bootstrap-typeahead.js",
                "~/Scripts/libryjs/bootstrap-tour.js",
                "~/Scripts/libryjs/jquery.cookie.js",
                "~/Scripts/libryjs/fullcalendar.min.js",
                "~/Scripts/libryjs/jquery.dataTables.min.js",
                "~/Scripts/libryjs/excanvas.js",
                "~/Scripts/libryjs/jquery.flot.min.js",
                "~/Scripts/libryjs/jquery.flot.pie.min.js",
                "~/Scripts/libryjs/jquery.flot.stack.js",
                "~/Scripts/libryjs/jquery.flot.resize.min.js",
                "~/Scripts/libryjs/jquery.chosen.min.js",
                "~/Scripts/libryjs/jquery.uniform.min.js",
                "~/Scripts/libryjs/jquery.colorbox.min.js",
                "~/Scripts/libryjs/jquery.cleditor.min.js",
                "~/Scripts/libryjs/jquery.noty.js",
                "~/Scripts/libryjs/jquery.elfinder.min.js",
                "~/Scripts/libryjs/jquery.raty.min.js",
                "~/Scripts/libryjs/jquery.iphone.toggle.js",
                "~/Scripts/libryjs/jquery.autogrow-textarea.js",
                "~/Scripts/libryjs/jquery.uploadify-3.1.min.js",
                "~/Scripts/libryjs/jquery.history.js",
                "~/Scripts/libryjs/charisma.js"));

            //bundles.Add(new ScriptBundle("dashboard/js")
            //    .Include("~/Scripts/libryjs/bootstrap-alert.js",
            //     "~/Scripts/libryjs/bootstrap-button.js",
            //     "~/Scripts/libryjs/bootstrap-carousel.js",
            //     "~/Scripts/libryjs/bootstrap-dropdown.js",
            //     "~/Scripts/libryjs/bootstrap-collapse.js",
            //     "~/Scripts/libryjs/bootstrap-modal.js",
            //     "~/Scripts/libryjs/bootstrap-popover.js",
            //     "~/Scripts/libryjs/bootstrap-scrollspy.js",
            //     "~/Scripts/libryjs/bootstrap-tab.js",
            //     "~/Scripts/libryjs/bootstrap-tooltip.js",
            //     "~/Scripts/libryjs/bootstrap-tour.js",
            //     "~/Scripts/libryjs/bootstrap-transition.js",
            //     "~/Scripts/libryjs/bootstrap-typeahead.js",
            //     "~/Scripts/libryjs/charisma.js",
            //     "~/Scripts/libryjs/excanvas.js",
            //        "~/Scripts/libryjs/fullcalendar.min.js",
            //        "~/Scripts/libryjs/jquery-1.7.2.min.js",
            //          "~/Scripts/libryjs/jquery-ui-1.8.21.custom.min.js",
            //          "~/Scripts/libryjs/jquery.autogrow-textarea.js",
            //           "~/Scripts/libryjs/jquery.chosen.min.js"));
            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new StyleBundle("~/AdminContent/css").Include("~/Content/admin/bootstrap-cerulean.css",
                "~/Content/admin/bootstrap-responsive.css",
                "~/Content/admin/charisma-app.css",
                "~/Content/admin/chosen.css",
                "~/Content/admin/colorbox.css",
                "~/Content/admin/elfinder.min.css",
                "~/Content/admin/elfinder.theme.css",
                "~/Content/admin/fullcalendar.css",
                "~/Content/admin/fullcalendar.print.css",
                "~/Content/admin/jquery.cleditor.css",
                "~/Content/admin/jquery.iphone.toggle.css",
                "~/Content/admin/jquery.noty.css",
                "~/Content/admin/jquery-ui-1.8.21.custom.css",
                "~/Content/admin/noty_theme_default.css",
                "~/Content/admin/opa-icons.css",
                "~/Content/admin/uniform.default.css",
                "~/Content/admin/uploadify.css"));

            bundles.Add(new StyleBundle("~/Content/themes/base/css").Include(
                        "~/Content/themes/base/jquery.ui.core.css",
                        "~/Content/themes/base/jquery.ui.resizable.css",
                        "~/Content/themes/base/jquery.ui.selectable.css",
                        "~/Content/themes/base/jquery.ui.accordion.css",
                        "~/Content/themes/base/jquery.ui.autocomplete.css",
                        "~/Content/themes/base/jquery.ui.button.css",
                        "~/Content/themes/base/jquery.ui.dialog.css",
                        "~/Content/themes/base/jquery.ui.slider.css",
                        "~/Content/themes/base/jquery.ui.tabs.css",
                        "~/Content/themes/base/jquery.ui.datepicker.css",
                        "~/Content/themes/base/jquery.ui.progressbar.css",
                        "~/Content/themes/base/jquery.ui.theme.css"));
        }
    }
}