using ControllerV1.Infrastructure;
using ControllerV1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ControllerV1.Controllers
{
    public class AdminController : BaseController
    {
        //[Local]
        public ActionResult DeleteUserAt(int id = 0)
        {
            if(users.Count != 0 && id >= 0 && id < users.Count)
            {
                users.RemoveAt(id);
            }
            return View("UserList", users);
        }
    }
}