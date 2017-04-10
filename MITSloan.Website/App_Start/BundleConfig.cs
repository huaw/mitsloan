using System.Web.Optimization;

namespace MITSloan.Website
{
    public static class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/master/scripts")
             .Include("~/Static/Core/Js/mitsloan.min.js"));

            bundles.Add(new Bundle("~/master/styles")
                .Include("~/Static/Core/Css/app.min.css"));
        }
    }
}