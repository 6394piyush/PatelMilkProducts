using PatelMilkProducts.Interfaces;
using PatelMilkProducts.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace PatelMilkProducts.AccountsDAL
{
    public class CrudEmpAcc:IAccountsOperations
    {
        private EmpDBContext db = new EmpDBContext();
        

        public bool DeleteEmpAccount(int? id)
        {
            EmpAccount empAccount = FindEmpAccount(id);
            db.EmpAccounts.Remove(empAccount);
            db.SaveChanges();
            return true;
        }

        public bool EditEmpAccount(EmpAccount emp)
        {
            db.Entry(emp).State = EntityState.Modified;
            db.SaveChanges();
            return true;
        }

        public EmpAccount FindEmpAccount(int? id)
        { 
            return db.EmpAccounts.Find(id);
        }

        public bool CreateEmpAccount(EmpAccount empAccount)
        {
            db.EmpAccounts.Add(empAccount);
            db.SaveChanges();
            return true;
        }

        public List<EmpAccount> MonthlyEntries(int month)
        {
            return db.EmpAccounts.Where(emp => (emp.CurrDate.Month == month)).ToList();
        }
    }
}