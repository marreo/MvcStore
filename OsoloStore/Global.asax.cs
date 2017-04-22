using OsoloStore.App_Start;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace OsoloStore
{
    public class MvcApplication : System.Web.HttpApplication
	{

		public static void RegisterGlobalFilters (GlobalFilterCollection filters)
		{
			filters.Add (new HandleErrorAttribute ());
		}

		protected void Application_Start ()
		{
			AreaRegistration.RegisterAllAreas ();
			RegisterGlobalFilters (GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
	}
}
