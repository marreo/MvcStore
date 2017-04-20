using System.Web.Optimization;

namespace OsoloStore.App_Start
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/scripts")
                .Include("~/Scripts/jquery-{version}.js")
                .Include("~/Scripts/bootstrap.js")
                );

            bundles.Add(new ScriptBundle("~/bundles/scripts/custom")
                .Include("~/Assets/Scripts/store-items.js")
                .Include("~/Assets/Scripts/store-order.js")
                );

            bundles.Add(new StyleBundle("~/bundles/css")
                .Include("~/Content/bootstrap.css")
                .Include("~/Content/toastr.css")
                );

            bundles.Add(new StyleBundle("~/bundles/css/custom")
                .Include("~/Assets/Styles/store-item.css")
                .Include("~/Assets/Styles/store-nav.css")
                );

            //Override to enabling bundling and minification locally
            BundleTable.EnableOptimizations = true;
        }
    }
}