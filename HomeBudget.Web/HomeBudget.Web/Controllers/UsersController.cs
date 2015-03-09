using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using HomeBudget.Source;
using HomeBudget.Web.Infrastructure;

namespace HomeBudget.Web.Controllers
{
    public class UsersController : Controller
    {
        private BudgetDb db = new BudgetDb();
        
        [HttpGet]
        public ActionResult CalculateBudget(int? id)
        {

            var model = from r in db.UsersD
                        orderby r.Fname
                        where r.Id == id
                        select r;
            //var ID = Convert.ToInt32(id);
            Users users = db.UsersD.Find(id);
            if (users == null)
            {
                return HttpNotFound();
            }
            return View(model.ToList());
        }
        [HttpPost]
        // [Bind(Include = "Id,Fname,Lname,Salary")]int id
        //string responsables, bool checkResp = false
        public ActionResult CalculateBudget(int[] id, string name)
        {

            var model = from r in db.UsersD
                        orderby r.Fname
                        select r;
            Users users = db.UsersD.Find(id);
            if (users == null)
            {
                return HttpNotFound();
            }
            return View(model.ToList());
        }


        // GET: Users
        [HttpGet]
        public ActionResult Index(string name)
        {
            if (name == null)
            {
                
            }
            return View(db.UsersD.ToList());
        }
        [HttpPost]
        public ActionResult Index(IEnumerable<Users> myUsers)
        {
            if (myUsers == null)
            {
                return HttpNotFound();
            }
            var model = from r in myUsers
                        
                        orderby r.Fname
                        where r.Select == true
                        select r;
             
            return View(model);
        }
        // GET: Users/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Users users = db.UsersD.Find(id);
            if (users == null)
            {
                return HttpNotFound();
            }
            return View(users);
        }



        // GET: Users/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Users/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Fname,Lname,Salary")] Users users)
        {
            if (ModelState.IsValid)
            {
                db.UsersD.Add(users);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(users);
        }

        // GET: Users/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Users users = db.UsersD.Find(id);
            if (users == null)
            {
                return HttpNotFound();
            }
            return View(users);
        }

        // POST: Users/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Fname,Lname,Salary")] Users users)
        {
            if (ModelState.IsValid)
            {
                db.Entry(users).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(users);
        }

        // GET: Users/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Users users = db.UsersD.Find(id);
            if (users == null)
            {
                return HttpNotFound();
            }
            return View(users);
        }

        // POST: Users/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Users users = db.UsersD.Find(id);
            db.UsersD.Remove(users);
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
