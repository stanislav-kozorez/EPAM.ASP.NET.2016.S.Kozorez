using DarkSide.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DarkSide.Controllers
{
    public class PersonController : Controller
    {
        private readonly PersonService service = new PersonService();
        // GET: Sides
        public ActionResult Get(int id = 0)
        {
            var person = id >= 0 && id < service.Persons.Count ? service.Persons[id] : service.Persons[0];
            return View("Person", person);
        }

        public ActionResult ChangeSide(string side = "dark", int id = 0)
        {
            var person = id >= 0 && id < service.Persons.Count ? service.Persons[id] : service.Persons[0];
            person.Side = side;
            return View("Person", person);
        }
    }
}