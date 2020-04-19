using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PatelMilkProducts.Models
{
    public class UserRoleMapping
    {
        public int Id { get; set; }
        public int UsersId { get; set; }
        public int RoleMasterId { get; set; }
        public virtual Users Users { get; set; }
        public virtual RoleMaster RoleMaster { get;set; }
    }
}