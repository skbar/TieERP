using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TieERP.Models;

namespace TieERP.Controllers
{
    public class BaseController : Controller
    {
        protected ApplicationDbContext _db = new ApplicationDbContext();

        protected override void Dispose(bool disposing)
        {
            _db.Dispose();
            base.Dispose(disposing);
        }
    }
}