using LabPerformance01.Models;
using LabPerformance01.Models.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LabPerformance01.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            Admin m = new Admin();
            return View(m);
        }

        [HttpPost]
        public ActionResult Index(Admin m)
        {
            if (ModelState.IsValid)
            {
                Database db = new Database();
                bool b = db.Admins.CheckAdmin(m);
                if (b)
                {
                    return RedirectToAction("Index", "Admin");
                }
                else
                {
                    ViewBag.Error = "Your username & password does not match";
                }
            }
            return View();
        }
    }
}