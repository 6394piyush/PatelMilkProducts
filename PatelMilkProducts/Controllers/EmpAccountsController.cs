using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using PatelMilkProducts.AccountsDAL;
using PatelMilkProducts.Helper;
using PatelMilkProducts.Interfaces;
using PatelMilkProducts.Models;

namespace PatelMilkProducts.Controllers
{   [Authorize]
    public class EmpAccountsController : Controller
    {
        private EmpDBContext db = new EmpDBContext();
        AccountManager am = new AccountManager(new CrudEmpAcc());

        #region  GET: EmpAccounts

        public ActionResult Index()
        {
           
            return View(am.GetAccountsOperations().GetAllAccounts());
          
        }
        #endregion

        #region GET: EmpAccounts/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            EmpAccount empAccount=am.GetAccountsOperations().FindEmpAccount(id);

            if (empAccount == null)
            {
                return HttpNotFound();
            }
            return View(empAccount);
        }
        #endregion

        #region GET: EmpAccounts/Create
        public ActionResult Create()
        {
            
            return View();
        }
        #endregion

        #region POST: EmpAccounts/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,EmployeesId,Amount,TransactionType,Signature,Comments,CurrDate")] EmpAccount empAccount)
        {
            if (ModelState.IsValid)
            {
                if(am.GetAccountsOperations().CreateEmpAccount(empAccount))
                return RedirectToAction("Index");
            }

            
            return View(empAccount);
        }
        #endregion

        #region GET: EmpAccounts/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EmpAccount empAccount = am.GetAccountsOperations().FindEmpAccount(id);
            if (empAccount == null)
            {
                return HttpNotFound();
            }
            ViewBag.EmployeesId = am.GetAccountsOperations().editListEmpAccounts(empAccount.Employees.Id, empAccount.Employees.Village);
            return View(empAccount);
        }
        #endregion

        #region POST: EmpAccounts/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,EmployeesId,Amount,TransactionType,Signature,Comments,CurrDate")] EmpAccount empAccount)
        {
            if (ModelState.IsValid)
            {
               if(am.GetAccountsOperations().EditEmpAccount(empAccount))
                return RedirectToAction("Index");
            }
            ViewBag.EmployeesId = am.GetAccountsOperations().editListEmpAccounts(empAccount.Employees.Id, empAccount.Employees.Village);
            return View(empAccount);
        }
        #endregion

        #region GET: EmpAccounts/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EmpAccount empAccount = am.GetAccountsOperations().FindEmpAccount(id);
            if (empAccount == null)
            {
                return HttpNotFound();
            }
            return View(empAccount);
        }
        #endregion

        #region POST: EmpAccounts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            am.GetAccountsOperations().DeleteEmpAccount(id);
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
        [HttpPost]
        public JsonResult GetVillageMembers(string VName)
        {
            var vlist = db.Employees.Where(emp => (emp.Village == VName)).ToList();
                      
            return Json(vlist);
        }
        #endregion


    }
}
