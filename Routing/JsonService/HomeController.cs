using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace JsonService
{
    public class HomeController: Controller
    {
        public ActionResult Index()
        {
            ViewBag.Controller = "JsonController";
            return Json("Json", JsonRequestBehavior.AllowGet);
        }
    }
}
