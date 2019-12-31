namespace PatelMilkProducts.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FileUploadChnages : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.MilkEntryUploads", "EmployeeName", c => c.String());
            AddColumn("dbo.MilkEntryUploads", "EmployeeFatherName", c => c.String());
            DropColumn("dbo.MilkEntryUploads", "EmployeeNameHindi");
        }
        
        public override void Down()
        {
            AddColumn("dbo.MilkEntryUploads", "EmployeeNameHindi", c => c.String());
            DropColumn("dbo.MilkEntryUploads", "EmployeeFatherName");
            DropColumn("dbo.MilkEntryUploads", "EmployeeName");
        }
    }
}
