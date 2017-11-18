using System.Web.Mvc;
using System.Web.Routing;

// ReSharper disable CheckNamespace
namespace Mvc4WebBootstrap
// ReSharper restore CheckNamespace
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            //this line is to ignore the routing of trace file which is "trace.axd"
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}