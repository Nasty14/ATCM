using System.Web;
using System.Web.Optimization;

namespace MyProductManager
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            // pri bundle-ing e ocherednost' vazhna!!!!

            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js")); //{{version}} - eto parametr, dajushij poslednuju versiju

            bundles.Add(new ScriptBundle("~/bundles/unobstrusive").Include(
            "~/Scripts/jquery.unobstrusive*"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*")); // vse novye tegi html =a objedinjaet

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));// izmenjaet vid okna pri izmenenie ego razmera, ne podderzhivaetsja starymi versijami, poetomu nado zdes' objazatel'no zadat'

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css")); //objedinil dannye dva css file-a v odin

        }
    }
}
