using MvcRouting.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Routing.Constraints;
using System.Web.Routing;

namespace MvcRouting
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            //routes.MapMvcAttributeRoutes();

            routes.MapRoute("", "CompoundRouteConstraint/{controller}/{action}/{id}/{*catchall}",
                defaults: new { controller = "Home", action = "Index", id = "1" },
                constraints: new { id = new CompoundRouteConstraint( new IRouteConstraint[] { new LengthRouteConstraint(1, 2), new CustomConstraint("5") }) },
                namespaces: new[] { "MvcRouting.Controllers" });

            routes.MapRoute(name: "Json",
                url: "Json/{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional },
                constraints: new { controller = "^H.*"},
                namespaces: new[] { "JsonService" }
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional},
                namespaces: new[] { "MvcRouting.Controllers" }
            );
        }
    }
}
