using PatelMilkProducts.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PatelMilkProducts.Helper
{
    public class RegistrationDAL
    {
        public bool Registration(Employees emp,Users usr)
        {
            EmpDBContext db = new EmpDBContext();
            try
            {
                db.Users.Add(usr);
                db.Employees.Add(emp);
                db.SaveChanges();

                var empFetch = db.Employees.Where(ep => (ep.Name == emp.Name & ep.FatherName == emp.FatherName & ep.Village == emp.Village)).ToList();
                var usrFetch = db.Users.Where(up => up.Username == usr.Username).ToList();


                string ids = "IdEmp: " + empFetch[0].Id + "IdUsr" + usrFetch[0].Id;
                UserEmpMapping userEmpMapping = new UserEmpMapping()
                {
                    UsersId = usrFetch[0].Id,
                    EmployeesId = empFetch[0].Id
                };

                db.UserEmpMappings.Add(userEmpMapping);
                db.SaveChanges();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }


            return true;
        }
    }
}