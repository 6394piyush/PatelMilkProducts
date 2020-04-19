using PatelMilkProducts.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PatelMilkProducts.Helper
{
    public class RegistrationManager
    {
        public bool PopulateEntries(FormCollection formcollection)
        {
            
            PasswordHasher ph = new PasswordHasher();
            RegistrationDAL rgdal = new RegistrationDAL();

            Users usr = new Users()
            {
                Username = formcollection["Logins.Username"],
                UserPassword = ph.HashPassword(formcollection["Logins.UserPassword"]).ToString()
            };

            Employees emp = new Employees()
            {
                Name = formcollection["Employees.Name"],
                FatherName = formcollection["Employees.FatherName"],
                Village = formcollection["SelectVillage"],
                Contact = Int32.Parse(formcollection["Employees.Contact"])
            };


            return rgdal.Registration(emp, usr);

            
        }
    }
}