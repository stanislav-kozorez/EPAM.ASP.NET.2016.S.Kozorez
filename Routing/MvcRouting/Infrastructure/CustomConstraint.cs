using System.Web;
using System.Web.Routing;

namespace MvcRouting.Infrastructure
{
    public class CustomConstraint : IRouteConstraint
    {
        private readonly string prohibitedValue;

        public CustomConstraint(string prohibitedValue)
        {
            this.prohibitedValue = prohibitedValue;
        }
        
        public bool Match(HttpContextBase httpContext, Route route, string parameterName, RouteValueDictionary values, RouteDirection routeDirection)
        {
            return string.Compare(values[parameterName].ToString(), prohibitedValue) != 0;
        }
    }
}