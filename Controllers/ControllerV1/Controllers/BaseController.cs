using ControllerV1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ControllerV1.Controllers
{
    public class BaseController : Controller
    {
        protected readonly List<User> users;

        public BaseController()
        {
            users = new List<User>()
            {
                new User() { Name = "User1"},
                new User() { Name = "User2"},
                new User() { Name = "User3"}
            };
        }
        protected override void HandleUnknownAction(string actionName)
        {
            ViewBag.ActionName = actionName;
            this.View("NotFound").ExecuteResult(this.ControllerContext);
        }
    }
}