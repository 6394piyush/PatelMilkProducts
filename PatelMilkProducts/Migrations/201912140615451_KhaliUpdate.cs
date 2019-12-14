namespace PatelMilkProducts.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class KhaliUpdate : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Khalis", "EmployeesName", c => c.String());
            AddColumn("dbo.Khalis", "EmployeesFatherName", c => c.String());
            AddColumn("dbo.Khalis", "EmployeesVillage", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Khalis", "EmployeesVillage");
            DropColumn("dbo.Khalis", "EmployeesFatherName");
            DropColumn("dbo.Khalis", "EmployeesName");
        }
    }
}
