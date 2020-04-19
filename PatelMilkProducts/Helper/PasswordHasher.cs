using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PatelMilkProducts.Helper
{
    public class PasswordHasher
    {
        public int HashPassword(string pass)
        {
            try { 
            return pass.GetHashCode();
            }
            catch
            {
                throw new Exception("Cannot Hash the password");
            }
        }
    }
}