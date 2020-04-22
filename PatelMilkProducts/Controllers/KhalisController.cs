using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using PatelMilkProducts.Helper;
using PatelMilkProducts.KhaliDAL;
using PatelMilkProducts.Models;

namespace PatelMilkProducts.Controllers
{   [Authorize]
    public class KhalisController : Controller
    {
        private EmpDBContext db = new EmpDBContext();
        private KhalisManager km = new KhalisManager(new CrudKhali());

        #region GET: Khalis
        public ActionResult Index()
        {
            
            return View(km.GetKhaliOperations().GetAllKhalis());
        }
        #endregion

        #region GET: Khalis/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Khali khali=km.GetKhaliOperations().FindKhali(id);

            if (khali == null)
            {
                return HttpNotFound();
            }
            return View(khali);
        }
        #endregion

        #region GET: Khalis/Create
        public ActionResult Create()
        {
            return View();
        }
        #endregion

        #region POST: Khalis/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,EmployeesId,EmployeesName,EmployeesFatherName,EmployeesVillage,Qty,GivenDate,Rate,Signature")] Khali khali)
        {
            if (ModelState.IsValid)
            {
                km.GetKhaliOperations().CreateKhali(khali);
                return RedirectToAction("Index");
            }
            return View(khali);
        }
        #endregion

        #region GET: Khalis/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Khali khali = km.GetKhaliOperations().FindKhali(id);
            if (khali == null)
            {
                return HttpNotFound();
            }
            ViewBag.EmployeesId = km.GetKhaliOperations().editListKhali(khali.Employees.Id, khali.Employees.Village);
            return View(khali);
        }
        #endregion

        #region POST: Khalis/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,EmployeesId,EmployeesName,EmployeesFatherName,EmployeesVillage,Qty,GivenDate,Rate,Signature")] Khali khali)
        {
            if (ModelState.IsValid)
            {
                km.GetKhaliOperations().EditKhali(khali);
                return RedirectToAction("Index");
            }
            ViewBag.EmployeesId = km.GetKhaliOperations().editListKhali(khali.Employees.Id, khali.Employees.Village);
            return View(khali);
        }
        #endregion

        #region GET: Khalis/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Khali khali = km.GetKhaliOperations().FindKhali(id);
            if (khali == null)
            {
                return HttpNotFound();
            }
            return View(khali);
        }

        #endregion

        #region POST: Khalis/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            
            return RedirectToAction("Index");
        }
        #endregion

        #region Dispose Objects
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
        #endregion

        #region Get Village Members
        public JsonResult GetVillageMembers(string vname)
        {
            return Json(db.Employees.Where(emp => (emp.Village == vname)).ToList());
        }
        #endregion

        #region Get Monthly Entries
        public JsonResult GetEntries(int MName)
        {
                return Json(km.GetKhaliOperations().MonthlyEntries(MName));
        }
        #endregion

    }
}
