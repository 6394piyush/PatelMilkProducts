using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PatelMilkProducts.Models
{
    public class AuthManager
    {
        public string loggedInUsername = "";
        EmpDBContext db = new EmpDBContext();

        public bool LogIn(string username,string password)
        {
            int hash = HashPassword(password);
            if(userEntryExistsInDb(username,hash.ToString()))
            {
                loggedInUsername = username;
                return true;
            }
            return false;
        }

        private bool userEntryExistsInDb(string username, string hash)
        {
            
            
            
            try {
                var usr = db.Users.Where(p => (p.Username == username & p.UserPassword == hash)).ToList();
                if (usr.Count > 0)
                    return true;
                return false;
            }
            catch
            {
                throw new Exception();
            }
            
        }

        private int HashPassword(string password)
        {
            Helper.PasswordHasher pass = new Helper.PasswordHasher();
            return pass.HashPassword(password);
        }

        public bool usernameAvailability(string usename)
        {
            var usr = db.Users.Where(p => p.Username == usename).ToList();
                if (usr.Count > 0)
                return true;
                return false;
        }
    }
}