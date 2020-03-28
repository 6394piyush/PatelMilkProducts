using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using PatelMilkProducts.Models;

namespace PatelMilkProducts.Controllers
{
    public class KhalisController : Controller
    {
        private EmpDBContext db = new EmpDBContext();

        // GET: Khalis
        public ActionResult Index()
        {
            var khali = db.Khali.Include(k => k.Employees);
            return View(khali.ToList());
        }

        // GET: Khalis/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Khali khali = db.Khali.Find(id);
            if (khali == null)
            {
                return HttpNotFound();
            }
            return View(khali);
        }

        // GET: Khalis/Create
        public ActionResult Create()
        {
            ViewBag.EmployeesId = new SelectList(db.Employees, "Id", "Name");
            return View();
        }

        // POST: Khalis/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,EmployeesId,EmployeesName,EmployeesFatherName,EmployeesVillage,Qty,GivenDate,Rate,Signature")] Khali khali)
        {
            if (ModelState.IsValid)
            {
                db.Khali.Add(khali);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.EmployeesId = new SelectList(db.Employees, "Id", "Name", khali.EmployeesId);
            return View(khali);
        }

        // GET: Khalis/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Khali khali = db.Khali.Find(id);
            if (khali == null)
            {
                return HttpNotFound();
            }
            ViewBag.EmployeesId = new SelectList(db.Employees, "Id", "Name", khali.EmployeesId);
            return View(khali);
        }

        // POST: Khalis/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,EmployeesId,EmployeesName,EmployeesFatherName,EmployeesVillage,Qty,GivenDate,Rate,Signature")] Khali khali)
        {
            if (ModelState.IsValid)
            {
                db.Entry(khali).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.EmployeesId = new SelectList(db.Employees, "Id", "Name", khali.EmployeesId);
            return View(khali);
        }

        // GET: Khalis/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Khali khali = db.Khali.Find(id);
            if (khali == null)
            {
                return HttpNotFound();
            }
            return View(khali);
        }

        // POST: Khalis/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Khali khali = db.Khali.Find(id);
            db.Khali.Remove(khali);
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
        public JsonResult GetVillageMembers(string vname)
        {
            return Json(db.Employees.Where(emp => (emp.Village == vname)).ToList());
        }
        public JsonResult GetEntries(int MName)
        {

            return Json(db.Khali.Where(emp => (emp.GivenDate.Month == MName)).ToList());



        }
       
    }
}
