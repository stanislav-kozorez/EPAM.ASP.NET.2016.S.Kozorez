using Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Models.Infrastructure
{
    public class PersonModelBinder : IModelBinder
    {
        public object BindModel(ControllerContext controllerContext, ModelBindingContext bindingContext)
        {
            var model = bindingContext.Model as Person ?? new Person();

            model.FirstName = GetValue(bindingContext, "FirstName");
            model.LastName = GetValue(bindingContext, "LastName");

            return model;
        }

        private string GetValue(ModelBindingContext context, string name)
        {
            var valueProvider = context.ValueProvider;
            var valueProviderResult = valueProvider.GetValue(name);

            switch (name)
            {
                case "FirstName":
                    if (valueProviderResult == null || valueProviderResult.AttemptedValue.Length < 2)
                        return "John";
                    break;
                case "LastName":
                    if (valueProviderResult == null || valueProviderResult.AttemptedValue.Length < 3)
                        return "Smith";
                    break;
            }

            return valueProviderResult.AttemptedValue;
        }
    }
}