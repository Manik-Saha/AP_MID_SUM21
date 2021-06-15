using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Lecture5.Models;
using Lecture5.Models.Database;

namespace Lecture5.Controllers
{
    public class ProductController : Controller
    {
        public ActionResult Index()
        {
            Database db = new Database();
            var products = db.Products.getAll();
            return View(products);
        }

        [HttpGet]
        public ActionResult Create()
        {
            Product p = new Product();
            return View(p);
        }

        [HttpPost]
        public ActionResult Create(Product p)
        {
            if (ModelState.IsValid)
            {
                Database db = new Database();
                db.Products.Insert(p);
                return RedirectToAction("Index");
            }
            return View();
        }

        public ActionResult Edit(int id)
        {
            Database db = new Database();
            var p = db.Products.Edit(id);
            return View(p);
        }

        [HttpPost]
        public ActionResult Edit(Product p)
        {
            return View();
        }
    }
}