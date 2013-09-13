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

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/LoginScript").Include("~/Scripts/libryjs/jquery-1.7.2.min.js",
                "~/Scripts/libryjs/jquery-ui-1.8.21.custom.min.js",
                "~/Scripts/libryjs/jquery.uploadify-3.1.min.js"
                
                ));

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

            bundles.Add(new StyleBundle("~/LoginContent/css").Include("~/Content/admin/bootstrap-cerulean.css",
                 "~/Content/admin/bootstrap-responsive.css",
                 "~/Content/admin/charisma-app.css"
                 //"~/Content/admin/chosen.css",
                 //"~/Content/admin/colorbox.css",
                 //"~/Content/admin/elfinder.min.css",
                 //"~/Content/admin/elfinder.theme.css",
                 //"~/Content/admin/fullcalendar.css",
                 //"~/Content/admin/fullcalendar.print.css",
                 //"~/Content/admin/jquery.cleditor.css",
                 //"~/Content/admin/jquery.iphone.toggle.css",
                 //"~/Content/admin/jquery.noty.css",
                 //"~/Content/admin/jquery-ui-1.8.21.custom.css",
                 //"~/Content/admin/noty_theme_default.css",
                 //"~/Content/admin/opa-icons.css",
                 //"~/Content/admin/uniform.default.css",
                 //"~/Content/admin/uploadify.css"
               ));
           
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