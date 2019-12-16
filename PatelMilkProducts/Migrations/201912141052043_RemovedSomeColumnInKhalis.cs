namespace PatelMilkProducts.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemovedSomeColumnInKhalis : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Khalis", "EmployeesName");
            DropColumn("dbo.Khalis", "EmployeesFatherName");
            DropColumn("dbo.Khalis", "EmployeesVillage");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Khalis", "EmployeesVillage", c => c.String());
            AddColumn("dbo.Khalis", "EmployeesFatherName", c => c.String());
            AddColumn("dbo.Khalis", "EmployeesName", c => c.String());
        }
    }
}
