using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace HelloWorld
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            //bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
            //            "~/Scripts/jquery-{version}.js"
            //            ));

            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/assets/js/jquery-2.0.3.min.js"
                        ));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));


            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/assets/js/bootstrap.min.js",
                       "~/Scripts/assets/js/ace-elements.min.js",
                      "~/Scripts/assets/js/ace.min.js",

                      "~/Scripts/assets/js/jquery.dataTables.min.js",
                      "~/Scripts/assets/js/jquery.dataTables.bootstrap.js",
                      "~/Scripts/TwitterBootstrapMvcJs.js"
                      ));



            //bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
            //          "~/Scripts/bootstrap.js",
            //          "~/Scripts/TwitterBootstrapMvcJs.js"));

            //bundles.Add(new StyleBundle("~/Content/css").Include(
            //          "~/Content/assets/css/bootstrap.css",
            //          "~/Content/bootstrap-theme.css"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/assets/css/bootstrap.min.css",
                      "~/Content/assets/css/bootstrap-responsive.min.css",
                      "~/Content/assets/css/ace.min.css",
                      "~/Content/assets/css/ace-responsive.min.css",
                      "~/Content/assets/css/ace-skins.min.css",
                      "~/Content/assets/css/font-awesome.min.css"));
        }
    }
}