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
        [RegularExpression(@"\d{10}", ErrorMessage = "Please enter 10 digit Mobile No.")]
        public int Contact { get; set; }



    }
    public class EmpDBContext : DbContext
    {
        public DbSet<Employees> Employees { get; set; }
        public DbSet<Khali> Khali { get; set; }
        public DbSet<EmpAccount> EmpAccounts { get; set; }
        public DbSet<Users> Users { get; set; }
        public DbSet<RoleMaster> RoleMasters { get; set; }
        public DbSet<UserRoleMapping> UserRoleMappings { get; set; }
        public DbSet<UserEmpMapping> UserEmpMappings { get; set; }
        public DbSet<MilkEntryUpload> MilkEntryUploads { get; set; }
    }
    public enum Village
    {
        Chapda,
        Khatediya,
        Khadotiya,
        Khalkhala,
        Khedi,
        Kachhaliya,
        Rangrej,
        RangrejBlock,
        Ujaliya
    }
}