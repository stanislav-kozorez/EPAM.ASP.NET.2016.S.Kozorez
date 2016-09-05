using Machine.Specifications;
using Mock;
using System.Web.Routing;

namespace MvcRouting.Tests
{
    [Subject("Json request with to many params")]
    public class When_requesting_json_with_to_many_params
    { 
        static StubHttpContextForRouting httpContext;
        static RouteCollection routes;
        static RouteData routeData;

        Establish context = () =>
        {
            httpContext = new StubHttpContextForRouting(requestUrl: "~/Json/Home/Index/1/2/3");
            routes = new RouteCollection();
            RouteConfig.RegisterRoutes(routes);
        };

        Because of = () => routeData = routes.GetRouteData(httpContext);

        It should_be_null = () => routeData.ShouldBeNull();
    }

}
