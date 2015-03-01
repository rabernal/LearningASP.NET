using RBBudget.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RBBudget.Controllers
{
    public class HomeController : Controller
    {
        RBBudgetDb _Db = new RBBudgetDb();
        public ActionResult Index(string searchTerm = null)
        {
            var model =
                from r in _Db.Users
                orderby r.Salary ascending
                where searchTerm == null || r.Fname.StartsWith(searchTerm)
                select r;
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

        protected override void Dispose(bool disposing)
        {
            if (_Db != null)
            {
                _Db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}