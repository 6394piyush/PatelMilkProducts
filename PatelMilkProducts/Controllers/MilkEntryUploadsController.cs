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
    public class MilkEntryUploadsController : Controller
    {
        private EmpDBContext db = new EmpDBContext();

        // GET: MilkEntryUploads
        public ActionResult Index()
        {
            return View(db.MilkEntryUploads.ToList());
        }

        // GET: MilkEntryUploads/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MilkEntryUpload milkEntryUpload = db.MilkEntryUploads.Find(id);
            if (milkEntryUpload == null)
            {
                return HttpNotFound();
            }
            return View(milkEntryUpload);
        }

        // GET: MilkEntryUploads/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MilkEntryUploads/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,VillageName,EmployeeNameHindi,_1,_2,_3,_4,_5,_6,_7,_8,_9,_10,_11,_12,_13,_14,_15,_16,_17,_18,_19,_20,_21,_22,_23,_24,_25,_26,_27,_28,_29,_30,_31,TotalMilk,Amount,SYear,SMonth")] MilkEntryUpload milkEntryUpload)
        {
            if (ModelState.IsValid)
            {
                db.MilkEntryUploads.Add(milkEntryUpload);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(milkEntryUpload);
        }

        // GET: MilkEntryUploads/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MilkEntryUpload milkEntryUpload = db.MilkEntryUploads.Find(id);
            if (milkEntryUpload == null)
            {
                return HttpNotFound();
            }
            return View(milkEntryUpload);
        }

        // POST: MilkEntryUploads/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,VillageName,EmployeeNameHindi,_1,_2,_3,_4,_5,_6,_7,_8,_9,_10,_11,_12,_13,_14,_15,_16,_17,_18,_19,_20,_21,_22,_23,_24,_25,_26,_27,_28,_29,_30,_31,TotalMilk,Amount,SYear,SMonth")] MilkEntryUpload milkEntryUpload)
        {
            if (ModelState.IsValid)
            {
                db.Entry(milkEntryUpload).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(milkEntryUpload);
        }

        // GET: MilkEntryUploads/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MilkEntryUpload milkEntryUpload = db.MilkEntryUploads.Find(id);
            if (milkEntryUpload == null)
            {
                return HttpNotFound();
            }
            return View(milkEntryUpload);
        }

        // POST: MilkEntryUploads/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            MilkEntryUpload milkEntryUpload = db.MilkEntryUploads.Find(id);
            db.MilkEntryUploads.Remove(milkEntryUpload);
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
        public JsonResult GetVillages(string VName,string Sy,string Sm)
        {

            
            var vlist = db.MilkEntryUploads.Where(emp => (emp.Employees.Village == VName & emp.SMonth==Sm & emp.SYear==Sy)).ToList();
            //var vlist = db.Employees.ToList();            
            return Json(vlist);
        }
    }
}
