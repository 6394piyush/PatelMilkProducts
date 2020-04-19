using PatelMilkProducts.Models;
using PatelMilkProducts.VIewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PatelMilkProducts.Controllers
{   [Authorize]
    public class OverallDetailsController : Controller
    {
        // GET: OverallDetails
        public ActionResult Index(int id)
        {
            EmpDBContext db = new EmpDBContext();
            List<Employees> emp = db.Employees.Where(p=>p.Id==id).ToList();
            List<Khali> khalis = db.Khali.Where(p=>p.EmployeesId==id).ToList();
            List<EmpAccount> empacc = db.EmpAccounts.Where(p => p.EmployeesId == id).ToList();
            List<MilkEntryUpload> meup = db.MilkEntryUploads.Where(p => p.EmployeesId == id).ToList();






            // MilkEntryUpload milk = db.MilkEntryUploads.Find(id);
            OverallDetails od = new OverallDetails
            {
                Employees = emp,
                Khali = khalis,
                EmpAccounts = empacc,
                MilkEntryUploads = meup,
            };
            
            
            return View(od);
        }

    }
}