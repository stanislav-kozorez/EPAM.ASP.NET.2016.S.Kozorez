using ControllerV1.Models;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace ControllerV1.Controllers
{
    public class UserController : BaseController
    {        
        [HttpPost]
        public async Task<ActionResult> AddUser()
        {
            await Task.Factory.StartNew( () => users.Add(new User() { Name = "User" + (users.Count + 1) }));
            return View("UserList", users);
        }

        [HttpGet]
        public ActionResult UserList()
        {
            return View("UserList", users);
        }

        [HttpPost]
        [ActionName("UserList")]
        public ActionResult UserListJson()
        {
            return Json(users, JsonRequestBehavior.AllowGet);
        }
    }
}