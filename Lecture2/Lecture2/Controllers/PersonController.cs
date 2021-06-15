using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Lecture2.Models;

namespace Lecture2.Controllers
{
    public class PersonController : Controller
    {
        // GET: Person
        public ActionResult Index()
        {
            ViewBag.Name = "Manik Saha";
            TempData["University"] = "AIUB";
            //return View();
            return RedirectToAction("Details");
        }

        /*public ActionResult Details()
        {
            ViewData["Name"] = "Manik Saha";
            return View();
        }*/

        public ActionResult Details()
        {
            Person p = new Person();
            p.Name = "Manik Saha";
            p.Password = "113123";
            p.UserName = "manik_saha";

            return View(p);
        }
    }
}