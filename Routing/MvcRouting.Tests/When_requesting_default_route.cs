﻿using Machine.Specifications;
using Mock;
using System.Web.Mvc;
using System.Web.Routing;

namespace MvcRouting.Tests
{
    [Subject("Default Routing")]
    public class When_requesting_default_route
    {
        static StubHttpContextForRouting httpContext;
        static RouteCollection routes;
        static RouteData routeData;

        Establish context = () => 
        {
            httpContext = new StubHttpContextForRouting(requestUrl: "~/");
            routes = new RouteCollection();
            RouteConfig.RegisterRoutes(routes);
        };

        Because of = () => routeData = routes.GetRouteData(httpContext);

        It should_not_be_null = () => routeData.ShouldNotBeNull();
        It should_have_home_controller = () => routeData.Values["controller"].ShouldEqual("Home");
        It should_have_index_action = () => routeData.Values["action"].ShouldEqual("Index");
        It should_have_optional_id_param = () => routeData.Values["id"].ShouldEqual(UrlParameter.Optional);
    }
}
