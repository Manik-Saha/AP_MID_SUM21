using Lecture8.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lecture8.Controllers
{
    public class ProductController : Controller
    {
        PMSEntities context = new PMSEntities();
        // GET: Product
        public ActionResult Index()
        {
            var products = context.Products.ToList();
            return View(products);
        }
    }
}