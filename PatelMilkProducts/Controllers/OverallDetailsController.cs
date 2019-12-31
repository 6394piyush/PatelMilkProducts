using PatelMilkProducts.Models;
using PatelMilkProducts.VIewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PatelMilkProducts.Controllers
{
    public class OverallDetailsController : Controller
    {
        // GET: OverallDetails
        public ActionResult Index(int id)
        {
            EmpDBContext db = new EmpDBContext();
            List<Employees> emp = db.Employees.Where(p=>p.Id==id).ToList();
            List<Khali> khalis = db.Khali.Where(p=>p.EmployeesId==id).ToList();



            


            // MilkEntryUpload milk = db.MilkEntryUploads.Find(id);
            OverallDetails od = new OverallDetails
            {
                Employees = emp,
                Khali = khalis,
            };
            return View(od);
        }

    }
}