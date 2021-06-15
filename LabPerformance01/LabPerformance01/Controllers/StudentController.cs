using LabPerformance01.Models;
using LabPerformance01.Models.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LabPerformance01.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Add()
        {
            Student s = new Student();
            //Department d = new Department();
            return View(s);
        }

        [HttpPost]
        public ActionResult Add(Student s)
        {
            if (ModelState.IsValid)
            {
                Database db = new Database();
                db.Students.Insert(s);
                return RedirectToAction("All");
            }
            return View();
        }

        public ActionResult All()
        {
            Database db = new Database();
            var students = db.Students.GetAll();
            return View(students);
        }

        public ActionResult Edit(int id)
        {
            Database db = new Database();
            var s = db.Students.Get(id);
            return View(s);
        }

        [HttpPost]
        public ActionResult Edit(Student s)
        {
            Database db = new Database();
            db.Students.Update(s);
            return RedirectToAction("All");
        }

        public ActionResult Delete(int id)
        {
            Database db = new Database();
            db.Students.Delete(id);
            return RedirectToAction("All");
        }
    }
}