using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace integratedproject
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {

            //bundles.Add(new ScriptBundle("~/resource/jquery").Include("~/Scripts/jquery-1.10.2.min.js"));

            bundles.Add(new ScriptBundle("~/resource/flat/js").Include(
                "~/Scripts/jquery-1.10.2.min.js",
                 "~/Scripts/flatlab/bootstrap.min.js",
                "~/Scripts/flatlab/jquery.scrollTo.min.js",
                "~/Scripts/flatlab/jquery.nicescroll.js",
                "~/Scripts/flatlab/jquery.dcjqaccordion.2.7.js",
                "~/Scripts/flatlab/common-scripts.js"));


            bundles.Add(new StyleBundle("~/resource/flat/css").Include(
                  "~/Content/css/bootstrap.min.css",
                  "~/Content/css/bootstrap-reset.css",
                 
                  "~/Content/css/style.css",
                  "~/Content/css/style-responsive.css"));
        }
    }
}