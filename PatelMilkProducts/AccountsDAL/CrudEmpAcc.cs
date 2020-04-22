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

        #region EmpAccounts-Delete
        public bool DeleteEmpAccount(int? id)
        {

            EmpAccount empAccount = FindEmpAccount(id);
            try
            {
                db.EmpAccounts.Remove(empAccount);
                db.SaveChanges();
            }
            catch(Exception e)
            {
                Console.WriteLine("Error : "+e.ToString());
            }
            
            return true;
        }
        #endregion

        #region EmpAccounts-Edit
        public bool EditEmpAccount(EmpAccount emp)
        {
            try { 
            db.Entry(emp).State = EntityState.Modified;
            db.SaveChanges();
            }
            catch (Exception e)
            {
                Console.WriteLine("Error : " + e.ToString());
            }
            return true;
        }
        #endregion

        #region EmpAccounts-Find
        public EmpAccount FindEmpAccount(int? id)
        {
            EmpAccount emp = new EmpAccount();   
            try
            {
                emp=db.EmpAccounts.Find(id);
            }
            catch (Exception e)
            {
                Console.WriteLine("Error : " + e.ToString());
            }
            return emp;
            
        }
        #endregion

        #region EmpAccounts-Create
        public bool CreateEmpAccount(EmpAccount empAccount)
        {
            try
            {
                db.EmpAccounts.Add(empAccount);
                db.SaveChanges();
            }
            catch (Exception e)
            {
                Console.WriteLine("Error : " + e.ToString());
            }
            return true;
        }
        #endregion

        #region EmpAccounts-Monthly Entries
        public List<EmpAccount> MonthlyEntries(int month)
        {
            List<EmpAccount> empAccounts = new List<EmpAccount>();
            try
            {
                empAccounts = db.EmpAccounts.Where(emp => (emp.CurrDate.Month == month)).ToList();
            }
            catch (Exception e)
            {
                Console.WriteLine("Error : " + e.ToString());
            }
            return empAccounts;
        }
        #endregion

        #region EmpAccounts-Get All Entries
        public List<EmpAccount> GetAllAccounts()
        {
            List<EmpAccount> empAccounts = new List<EmpAccount>();
            try
            {
                empAccounts = db.EmpAccounts.ToList();
            }
            catch (Exception e)
            {
                Console.WriteLine("Error : " + e.ToString());
            }
            return empAccounts;

        }
        #endregion

        #region Select List Used in EmpAccount-Edit
        public SelectList editListEmpAccounts(int id, string village)
        {
            
            try
            {
               SelectList selectListItems = new SelectList(db.Employees.Where(r => r.Village == village), "Id", "Name", id);
                return selectListItems;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error : " + e.ToString());
                return null;
            }
            
        }

        #endregion
    }
}