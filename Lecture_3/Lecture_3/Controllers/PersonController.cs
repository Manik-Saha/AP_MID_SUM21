using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Lecture_3.Models;

namespace Lecture_3.Controllers
{
    public class PersonController : Controller
    {
        // GET: Person
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult create()
        {
            Person p = new Person();
            return View(p);
        }

        public ActionResult CreatePerson()
        {
            string name = Request["Name"].ToString();
            return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult CreateView(Person p)
        {
            return View(p);
        }
    }
}