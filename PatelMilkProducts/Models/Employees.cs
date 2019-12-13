using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace PatelMilkProducts.Models
{
    public class Employees
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string FatherName { get; set; }
        public string Village { get; set; }
        public int Contact { get; set; }
    }
    public class EmpDBContext : DbContext
    {
        public DbSet<Employees> Employees { get; set; }
    }
}