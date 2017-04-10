using System.Web.Mvc;
using System.Web.Routing;

namespace MITSloan.Website
{
    public static class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
		{
            routes.MapMvcAttributeRoutes();

            routes.MapRoute(
                name: "RobotsUrl",
                url: "Robots/{action}",
                defaults: new { controller = "Robots", action = "Index" });

            routes.MapRoute(
                "DefaultArea",
                "{language}/api/{area}/{controller}/{action}/{node}",
                new
                {
                    action = "Index",
                });

            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.IgnoreRoute("{*favicon}", new { favicon = @"(.*/)?favicon.ico(/.*)?" });
        }
    }
}