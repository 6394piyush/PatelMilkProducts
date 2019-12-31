namespace PatelMilkProducts.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FileUploadChnages_1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.MilkEntryUploads", "EmployeesId", c => c.Int(nullable: false));
            CreateIndex("dbo.MilkEntryUploads", "EmployeesId");
            AddForeignKey("dbo.MilkEntryUploads", "EmployeesId", "dbo.Employees", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.MilkEntryUploads", "EmployeesId", "dbo.Employees");
            DropIndex("dbo.MilkEntryUploads", new[] { "EmployeesId" });
            DropColumn("dbo.MilkEntryUploads", "EmployeesId");
        }
    }
}
