using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


/* This Controller returns a view (from Views/Home) when calling an appropriate method.*/
namespace MVCSite.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}