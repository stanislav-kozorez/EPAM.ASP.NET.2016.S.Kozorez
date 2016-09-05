using AnotherProj.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AnotherProj.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index()
        {
            return View(new Result()
            {
                Controller = "ProductController",
                Action = "Index"
            });
        }

        public ActionResult List()
        {
            return View(new Result()
            {
                Controller = "ProductController",
                Action = "List"
            });
        }
    }
}