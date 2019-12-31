namespace PatelMilkProducts.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FileUploadAddedForeignKey : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.MilkEntryUploads", "VillageName");
            DropColumn("dbo.MilkEntryUploads", "EmployeeName");
            DropColumn("dbo.MilkEntryUploads", "EmployeeFatherName");
        }
        
        public override void Down()
        {
            AddColumn("dbo.MilkEntryUploads", "EmployeeFatherName", c => c.String());
            AddColumn("dbo.MilkEntryUploads", "EmployeeName", c => c.String());
            AddColumn("dbo.MilkEntryUploads", "VillageName", c => c.String());
        }
    }
}
