using PatelMilkProducts.Interfaces;
using PatelMilkProducts.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PatelMilkProducts.KhaliDAL
{
    public class CrudKhali : IKhaliOperations
    {
        private EmpDBContext db = new EmpDBContext();

        #region Khali-Create
        public bool CreateKhali(Khali khali)
        {
            try
            {
                db.Khali.Add(khali);
                db.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error : " + e.ToString());
                return false;
            }


        }
        #endregion

        #region Khali-Delete
        public bool DeleteKhali(int? id)
        {
            try
            {
             Khali khali=FindKhali(id);
            db.Khali.Remove(khali);
            db.SaveChanges();
            return true;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error : " + e.ToString());
                return false;
            }
        }
        #endregion

        #region Khali-Edit
        public bool EditKhali(Khali khali)
        {
            try 
            {
                db.Entry(khali).State = EntityState.Modified;
                db.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error : " + e.ToString());
                return false;
            }
        }
        #endregion

        #region Select List for Khali Edit
        public SelectList editListKhali(int id, string village)
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

        #region Khali-Find
        public Khali FindKhali(int? id)
        {
            try
            {
                Khali khali = db.Khali.Find(id);
                return khali;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error : " + e.ToString());
                return null;
            }
        }
        #endregion

        #region Khalis-Get All Entries
        public List<Khali> GetAllKhalis()
        {
            try
            {
                var khali = db.Khali;
                return khali.ToList();
            }
            catch (Exception e)
            {
                Console.WriteLine("Error : " + e.ToString());
                return null;
            }


        }
        #endregion

        #region Monthly-Entries

        public List<Khali> MonthlyEntries(int month)
        {
            List<Khali> khalis = new List<Khali>();
            try
            {
                khalis = db.Khali.Where(kh => (kh.GivenDate.Month == month)).ToList();
            }
            catch (Exception e)
            {
                Console.WriteLine("Error : " + e.ToString());
            }
            return khalis;
        }
        #endregion
    }
}