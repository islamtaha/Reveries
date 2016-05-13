using System.Web;
using System.Web.Optimization;

namespace Reveries
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/Scripts")
                        .Include("~/Scripts/jquery-{version}.js")
                        .Include("~/Scripts/semantic.min.js")
                        .Include("~/Scripts/materialize.min.js")
                        .Include("~/Scripts/myScript.js"));

        }
    }
}
