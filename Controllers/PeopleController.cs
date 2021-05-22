using DemoApp_MVC5_.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DemoApp_MVC5_.Controllers
{
    public class PeopleController : Controller
    {
        // GET: People
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult ListPeople()
        {
            List<PersonModel> people = new List<PersonModel>();
            people.Add(new PersonModel { FirstName = "Ayon", LastName = "Chowdhury", Age = 23, IsAlive = true });
            people.Add(new PersonModel { FirstName = "abc", LastName = "def", Age = 50, IsAlive = true });
            people.Add(new PersonModel { FirstName = "qwe", LastName = "ert", Age = 97, IsAlive = false   });

            return View(people);
        }

    }
}