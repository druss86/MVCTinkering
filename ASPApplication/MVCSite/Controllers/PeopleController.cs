using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCSite.Models;

namespace MVCSite.Controllers
{
    public class PeopleController : Controller
    {
        // GET: People
        public ActionResult Index()
        {
            PersonModel p = new PersonModel();
            int i = 5 / p.Age;
            return View();
        }

        //Create Views by right-clicking method name and "Add View", in this case Template is "List" and Model Class is PersonModel. Creates ListPeople.cshtml
        public ActionResult ListPeople()
        {
            List<PersonModel> people = new List<PersonModel>();
            
            people.Add(new PersonModel{FirstName = "Steady", LastName = "Ed", Age = 87, IsAlive = false});
            people.Add(new PersonModel { FirstName = "Ken", LastName = "Climo", Age = 56 });
            people.Add(new PersonModel { FirstName = "Barry", LastName = "Schultz", Age = 54 });

            return View(people);
        }
    }
}