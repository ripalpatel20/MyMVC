using MyFirstMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyFirstMVC.Controllers
{
    public class PeopleController : Controller
    {
        // GET: People
        public ActionResult Index()
        {
            return View();
        }

        // GET: People
        public ActionResult ListPeople()
        {
            List<PersonModel> people = new List<PersonModel>();
            people.Add(new PersonModel { FirstName = "Ripal", LastName = "Patel", Age = 30 });
            people.Add(new PersonModel { FirstName = "Tejas", LastName = "Patel", Age = 32 });
            people.Add(new PersonModel { FirstName = "Viaan", LastName = "Patel", Age = 2 });
            return View(people);
        }
    }
}