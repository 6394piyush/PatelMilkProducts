using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using PatelMilkProducts.Models;

namespace PatelMilkProducts.Controllers
{
    public class EmpAccountsController : Controller
    {
        private EmpDBContext db = new EmpDBContext();

        // GET: EmpAccounts
        public ActionResult Index()
        {
            var empAccounts = db.EmpAccounts.Include(e => e.Employees);
            return View(empAccounts.ToList());
        }

        // GET: EmpAccounts/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EmpAccount empAccount = db.EmpAccounts.Find(id);
            if (empAccount == null)
            {
                return HttpNotFound();
            }
            return View(empAccount);
        }

        // GET: EmpAccounts/Create
        public ActionResult Create()
        {
            ViewBag.EmployeesId = new SelectList(db.Employees, "Id", "Name");
            return View();
        }

        // POST: EmpAccounts/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,EmployeesId,Amount,TransactionType,Signature,Comments")] EmpAccount empAccount)
        {
            if (ModelState.IsValid)
            {
                db.EmpAccounts.Add(empAccount);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.EmployeesId = new SelectList(db.Employees, "Id", "Name", empAccount.EmployeesId);
            return View(empAccount);
        }

        // GET: EmpAccounts/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EmpAccount empAccount = db.EmpAccounts.Find(id);
            if (empAccount == null)
            {
                return HttpNotFound();
            }
            ViewBag.EmployeesId = new SelectList(db.Employees, "Id", "Name", empAccount.EmployeesId);
            return View(empAccount);
        }

        // POST: EmpAccounts/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,EmployeesId,Amount,TransactionType,Signature,Comments")] EmpAccount empAccount)
        {
            if (ModelState.IsValid)
            {
                db.Entry(empAccount).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.EmployeesId = new SelectList(db.Employees, "Id", "Name", empAccount.EmployeesId);
            return View(empAccount);
        }

        // GET: EmpAccounts/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EmpAccount empAccount = db.EmpAccounts.Find(id);
            if (empAccount == null)
            {
                return HttpNotFound();
            }
            return View(empAccount);
        }

        // POST: EmpAccounts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            EmpAccount empAccount = db.EmpAccounts.Find(id);
            db.EmpAccounts.Remove(empAccount);
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
