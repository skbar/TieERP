using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TieERP.Models;

namespace TieERP.Controllers
{
    public class HomeController : BaseController
    {
        public ActionResult Index(string search = null)
        {
            IEnumerable<Warehouse> model;
            
            if (!string.IsNullOrEmpty(search))
                model = _db.Warehouses.Where(c => c.Name.Contains(search));
            else
                model = _db.Warehouses;

            var modelPreview = _db.Warehouses.ToList(); // Push model to list

            return View(model);
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