using AnotherProj.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace AnotherProj.Infrastructure
{
    public class CustomControllerActivator : IControllerActivator
    {
        public IController Create(RequestContext requestContext, Type controllerType)
        {
            if (controllerType == typeof(CustomerController))
            {
                controllerType = typeof(ProductController);
            }

            return (IController)DependencyResolver.Current.GetService(controllerType);
        }
    }
}