using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PatelMilkProducts.Models
{
    public class UserEmpMapping
    {
        public int Id { get; set; }
        public int UsersId { get; set; }
        public int EmployeesId { get; set; }
        public virtual Users Users { get; set; }
        public virtual Employees Employees { get; set; }
    }
}