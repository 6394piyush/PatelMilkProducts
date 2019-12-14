using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace PatelMilkProducts.Models
{
    public class Khali
    {   
        public int Id { get; set; }
        public int EmployeesId  { get; set; }
        public string EmployeesName { get; set; }
        public string EmployeesFatherName { get; set; }
        public string EmployeesVillage { get; set; }
        public int Qty { get; set; }
        public DateTime GivenDate { get; set; }
        public int Rate { get; set; }

        public string Signature { get; set; }

        public virtual Employees Employees { get; set; }

    }

    }