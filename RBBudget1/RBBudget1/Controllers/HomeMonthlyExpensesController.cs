using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MonthlyExpenses;
using RBBudget1.Infrastructure;

namespace RBBudget1.Controllers
{
    public class HomeMonthlyExpensesController : Controller
    {
        private HomeExpensesDb db = new HomeExpensesDb();

        // GET: HomeMonthlyExpenses
        public ActionResult Index()
        {
            return View(db.HomeMonthlyExpenses.ToList());
        }

        // GET: HomeMonthlyExpenses/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            HomeMonthlyExpenses homeMonthlyExpenses = db.HomeMonthlyExpenses.Find(id);
            if (homeMonthlyExpenses == null)
            {
                return HttpNotFound();
            }
            return View(homeMonthlyExpenses);
        }

        // GET: HomeMonthlyExpenses/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: HomeMonthlyExpenses/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Rent,Electricity,Water")] HomeMonthlyExpenses homeMonthlyExpenses)
        {
            if (ModelState.IsValid)
            {
                db.HomeMonthlyExpenses.Add(homeMonthlyExpenses);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(homeMonthlyExpenses);
        }

        // GET: HomeMonthlyExpenses/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            HomeMonthlyExpenses homeMonthlyExpenses = db.HomeMonthlyExpenses.Find(id);
            if (homeMonthlyExpenses == null)
            {
                return HttpNotFound();
            }
            return View(homeMonthlyExpenses);
        }

        // POST: HomeMonthlyExpenses/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Rent,Electricity,Water")] HomeMonthlyExpenses homeMonthlyExpenses)
        {
            if (ModelState.IsValid)
            {
                db.Entry(homeMonthlyExpenses).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(homeMonthlyExpenses);
        }

        // GET: HomeMonthlyExpenses/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            HomeMonthlyExpenses homeMonthlyExpenses = db.HomeMonthlyExpenses.Find(id);
            if (homeMonthlyExpenses == null)
            {
                return HttpNotFound();
            }
            return View(homeMonthlyExpenses);
        }

        // POST: HomeMonthlyExpenses/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            HomeMonthlyExpenses homeMonthlyExpenses = db.HomeMonthlyExpenses.Find(id);
            db.HomeMonthlyExpenses.Remove(homeMonthlyExpenses);
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
