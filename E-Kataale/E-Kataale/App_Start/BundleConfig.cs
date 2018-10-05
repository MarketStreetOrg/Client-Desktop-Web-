
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace E_Kataale.App_Start
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            
            StyleBundle(bundles);
            ScriptBundle(bundles);
        }

        public static void StyleBundle(BundleCollection bundles)
        {
            bundles.Add(new StyleBundle("~/css")
                     .Include("~/Content/bootstrap.css", "~/Content/dataTables.bootstrap4.css", "~/Content/jquery.dataTables.css", "~/Content/mdb.css","~/Content/Kataale.css"));

       
          

        }

        public static void ScriptBundle(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/js")
                     .Include("~/Scripts/jquery-3.0.0.js",
                     "~/Scripts/jquery.dataTables.js",
                     "~/Scripts/bootstrap.js",
                     "~/Scripts/custom.js"));
        }
    }
}