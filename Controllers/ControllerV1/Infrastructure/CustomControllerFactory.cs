using ControllerV1.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using System.Web.SessionState;

namespace ControllerV1.Infrastructure
{
    public class CustomControllerFactory : IControllerFactory
    {
        public IController CreateController(RequestContext requestContext, string controllerName)
        {
            Type targetType = null;

            switch (controllerName)
            {
                case "Admin":
                    targetType = !requestContext.HttpContext.Request.IsLocal? typeof(BaseController): typeof(AdminController);
                    break;
                case "User":
                    targetType = typeof(UserController);
                    break;
                case "Home":
                    targetType = typeof(HomeController);
                    break;
                default:
                    requestContext.RouteData.Values["controller"] = "Home";
                    targetType = typeof(HomeController);
                    break;
            }

            if (targetType == null)
                return null;

            return (IController)DependencyResolver.Current.GetService(targetType);
        }

        public SessionStateBehavior GetControllerSessionBehavior(RequestContext requestContext, string controllerName)
        {
            return controllerName == "Home" ? SessionStateBehavior.Disabled : SessionStateBehavior.Default;
        }

        public void ReleaseController(IController controller)
        {
            IDisposable disposable = controller as IDisposable;
            disposable?.Dispose();
        }
    }
}