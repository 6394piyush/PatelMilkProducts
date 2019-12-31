namespace PatelMilkProducts.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MilkEntryMonthYearUpdate : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.MilkEntryUploads", "SYear", c => c.String());
            AddColumn("dbo.MilkEntryUploads", "SMonth", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.MilkEntryUploads", "SMonth");
            DropColumn("dbo.MilkEntryUploads", "SYear");
        }
    }
}
