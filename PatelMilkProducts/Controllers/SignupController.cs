using PatelMilkProducts.Helper;
using PatelMilkProducts.Models;
using PatelMilkProducts.VIewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PatelMilkProducts.Controllers
{
    public class SignupController : Controller
    {
        // GET: Signup
        public ActionResult Index()
        {
            return View("Register");
        }
        [HttpPost]
        public ActionResult Index(FormCollection form)
        {
            AuthManager am = new AuthManager();
            if(am.usernameAvailability(form["logins.Username"]))
            {
                TempData["available"] = "Username Already Taken";

                return RedirectToAction("Index", "Signup");
            }
            else
            {
                RegistrationManager rm = new RegistrationManager();
                if(rm.PopulateEntries(form))
                    return RedirectToAction("Index", "Home");
                else
                    return RedirectToAction("Index", "Signup");

            }
                
               
        }
        
    }
}