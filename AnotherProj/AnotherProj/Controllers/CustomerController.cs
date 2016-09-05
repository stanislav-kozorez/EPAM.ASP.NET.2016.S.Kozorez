using AnotherProj.Infrastructure;
using AnotherProj.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace AnotherProj.Controllers
{
    public class CustomerController : Controller
    {
        //[ActionName("Index")]
        //[Local]
        //public ActionResult LocalIndex()
        //{
        //    return View(new Result()
        //    {
        //        Controller = "CustomerController",
        //        Action = "LocalIndex"
        //    });
        //}

        // GET: Customer
        public async Task<ActionResult> Index()
        {
            var data = await new RemoteService().GetRemoteData();
            return View(new Result()
            {
                Controller = "CustomerController",
                Action = "Index " + data
            });
        }

        public ActionResult List()
        {
            return View(new Result()
            {
                Controller = "CustomerController",
                Action = "List"
            });
        }
    }
}