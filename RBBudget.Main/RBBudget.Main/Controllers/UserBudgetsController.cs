using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using RBBudget.DataSource;
using RBBudget.Main.Infrastructure;

namespace RBBudget.Main.Controllers
{
    public class UserBudgetsController : Controller
    {
        private UserBudgetDb db = new UserBudgetDb();

        public ActionResult AutoSearch(string term)
        {
            var model =
                db.UsersBudget
                .Where(r => r.Fname.StartsWith(term))
                .Take(10)
                .Select(r => new
                {
                    label = r.Fname
                });
            return Json(model, JsonRequestBehavior.AllowGet);
        }
        // GET: UserBudgets
        public ActionResult Index(string searchResuletTerm)
        {
            var model =
            from r in db.UsersBudget
            orderby r.Salary ascending
            where searchResuletTerm == null || r.Fname.StartsWith(searchResuletTerm)
            select r;

            if (Request.IsAjaxRequest())
            {
                return PartialView("_displayUsersPartial", model);
            }
            return View(model.ToList());
        }

        // GET: UserBudgets/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            UserBudget userBudget = db.UsersBudget.Find(id);
            if (userBudget == null)
            {
                return HttpNotFound();
            }
            return View(userBudget);
        }

        // GET: UserBudgets/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: UserBudgets/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Fname,Lname,Salary")] UserBudget userBudget)
        {
            if (ModelState.IsValid)
            {
                db.UsersBudget.Add(userBudget);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(userBudget);
        }

        // GET: UserBudgets/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            UserBudget userBudget = db.UsersBudget.Find(id);
            if (userBudget == null)
            {
                return HttpNotFound();
            }
            return View(userBudget);
        }

        // POST: UserBudgets/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Fname,Lname,Salary")] UserBudget userBudget)
        {
            if (ModelState.IsValid)
            {
                db.Entry(userBudget).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(userBudget);
        }

        // GET: UserBudgets/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            UserBudget userBudget = db.UsersBudget.Find(id);
            if (userBudget == null)
            {
                return HttpNotFound();
            }
            return View(userBudget);
        }

        // POST: UserBudgets/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            UserBudget userBudget = db.UsersBudget.Find(id);
            db.UsersBudget.Remove(userBudget);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
