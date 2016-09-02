using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcRouting.Controllers
{
    [Route("Test")]
    public class AttributeTestController : Controller
    {
        [Route("Test/Show")]
        public ActionResult Index()
        {
            return View();
        }
    }
}