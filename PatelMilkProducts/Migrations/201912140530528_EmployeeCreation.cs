namespace PatelMilkProducts.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EmployeeCreation : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        FatherName = c.String(),
                        Village = c.String(),
                        Contact = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Khalis",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        EmployeesId = c.Int(nullable: false),
                        Qty = c.Int(nullable: false),
                        GivenDate = c.DateTime(nullable: false),
                        Signature = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Employees", t => t.EmployeesId, cascadeDelete: true)
                .Index(t => t.EmployeesId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Khalis", "EmployeesId", "dbo.Employees");
            DropIndex("dbo.Khalis", new[] { "EmployeesId" });
            DropTable("dbo.Khalis");
            DropTable("dbo.Employees");
        }
    }
}
