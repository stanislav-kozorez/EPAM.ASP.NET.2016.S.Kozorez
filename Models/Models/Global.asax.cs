﻿using Models.Infrastructure;
using Models.Models;
using System.Web.Mvc;
using System.Web.Routing;

namespace Models
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            //ValueProviderFactories.Factories.Insert(0,
            //    new CustomValueProviderFactory());

            ModelBinders.Binders.Add(typeof(Address), new CustomModelBinder());
        }
    }
}
