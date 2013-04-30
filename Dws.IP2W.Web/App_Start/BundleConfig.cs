using System.Web.Optimization;

namespace Dws.IP2W.Web
{
    public class BundleConfig
    {
        // For more information on Bundling, visit http://go.microsoft.com/fwlink/?LinkId=254725
        public static void RegisterBundles(BundleCollection bundles)
        {
            // Force optimization to be on or off, regardless of web.config setting
            //BundleTable.EnableOptimizations = false;

            bundles.UseCdn = true;

            // .debug.js, -vsdoc.js and .intellisense.js files 
            // are in BundleTable.Bundles.IgnoreList by default.
            // Clear out the list and add back the ones we want to ignore.
            // Don't add back .debug.js.
            bundles.IgnoreList.Clear();
            bundles.IgnoreList.Ignore("*-vsdoc.js");
            bundles.IgnoreList.Ignore("*intellisense.js");

            //Load this first
            bundles.Add(new ScriptBundle("~/bundles/modernizr")
                .Include("~/Scripts/modernizr-{version}.js"));
            
            //jQuery
            bundles.Add(new ScriptBundle("~/bundles/jquery", "//ajax.googleapis.com/ajax/libs/jquery/1.9.1/jquery.min.js")
                .Include("~/Scripts/jquery-{version}.js"));

            //3rd Party JavaScript files
            bundles.Add(new ScriptBundle("~/bundles/jsthirdlibs")
                            //.IncludeDirectory("~/Scripts", "*.js", searchSubdirectories: false)
                            .Include(
                            "~/Scripts/lib/json2.js", // for IE7
                            
                            //Jquery plugins
                            "~/Scripts/jquery.unobtrusive*",
                            "~/Scripts/jquery.validate*",

                            //AngularJs and AngularUI Bootstrap
                            "~/Scripts/angular.js", 
                            "~/Scripts/ui-bootstrap-tpls-{version}.js"));

            //Actual application JS files
            bundles.Add(new ScriptBundle("~/bundles/jsapplibs")
                .IncludeDirectory("~/Scripts/App/", "*.js", searchSubdirectories: false));

            bundles.Add(new StyleBundle("~/Content/css")
                .Include("~/Content/Site.css"));

            bundles.Add(new StyleBundle("~/Content/bootstrapcss", "//netdna.bootstrapcdn.com/twitter-bootstrap/2.3.1/css/bootstrap-combined.min.css")
                .Include(
                "~/Content/bootstrap.css",
                "~/Content/bootstrap.responsive.css"));
        }
    }
}