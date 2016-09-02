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
        public ActionResult Index(string id)
        {
            ViewBag.Controller = "JsonController";
            return Json($"Json: {id}", JsonRequestBehavior.AllowGet);
        }
    }
}
