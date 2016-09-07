using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Views.Controllers
{
    public class HomeController : Controller
    {  
        public ActionResult Index()
        {
            return View(new string[] { "1", "2", "3" });
        }

        public ActionResult CustomData()
        {
            return View("CustomData");
        }
    }
}