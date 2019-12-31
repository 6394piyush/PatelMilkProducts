namespace PatelMilkProducts.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MilkUploadFloat : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.MilkEntryUploads", "_1", c => c.Double(nullable: true));
            AlterColumn("dbo.MilkEntryUploads", "_2", c => c.Double(nullable: true));
            AlterColumn("dbo.MilkEntryUploads", "_3", c => c.Double(nullable: true));
            AlterColumn("dbo.MilkEntryUploads", "_4", c => c.Double(nullable: true));
            AlterColumn("dbo.MilkEntryUploads", "_5", c => c.Double(nullable: true));
            AlterColumn("dbo.MilkEntryUploads", "_6", c => c.Double(nullable: true));
            AlterColumn("dbo.MilkEntryUploads", "_7", c => c.Double(nullable: true));
            AlterColumn("dbo.MilkEntryUploads", "_8", c => c.Double(nullable: true));
            AlterColumn("dbo.MilkEntryUploads", "_9", c => c.Double(nullable: true));
            AlterColumn("dbo.MilkEntryUploads", "_10", c => c.Double(nullable: true));
            AlterColumn("dbo.MilkEntryUploads", "_11", c => c.Double(nullable: true));
            AlterColumn("dbo.MilkEntryUploads", "_12", c => c.Double(nullable: true));
            AlterColumn("dbo.MilkEntryUploads", "_13", c => c.Double(nullable: true));
            AlterColumn("dbo.MilkEntryUploads", "_14", c => c.Double(nullable: true));
            AlterColumn("dbo.MilkEntryUploads", "_15", c => c.Double(nullable: true));
            AlterColumn("dbo.MilkEntryUploads", "_16", c => c.Double(nullable: true));
            AlterColumn("dbo.MilkEntryUploads", "_17", c => c.Double(nullable: true));
            AlterColumn("dbo.MilkEntryUploads", "_18", c => c.Double(nullable: true));
            AlterColumn("dbo.MilkEntryUploads", "_19", c => c.Double(nullable: true));
            AlterColumn("dbo.MilkEntryUploads", "_20", c => c.Double(nullable: true));
            AlterColumn("dbo.MilkEntryUploads", "_21", c => c.Double(nullable: true));
            AlterColumn("dbo.MilkEntryUploads", "_22", c => c.Double(nullable: true));
            AlterColumn("dbo.MilkEntryUploads", "_23", c => c.Double(nullable: true));
            AlterColumn("dbo.MilkEntryUploads", "_24", c => c.Double(nullable: true));
            AlterColumn("dbo.MilkEntryUploads", "_25", c => c.Double(nullable: true));
            AlterColumn("dbo.MilkEntryUploads", "_26", c => c.Double(nullable: true));
            AlterColumn("dbo.MilkEntryUploads", "_27", c => c.Double(nullable: true));
            AlterColumn("dbo.MilkEntryUploads", "_28", c => c.Double(nullable: true));
            AlterColumn("dbo.MilkEntryUploads", "_29", c => c.Double(nullable: true));
            AlterColumn("dbo.MilkEntryUploads", "_30", c => c.Double(nullable: true));
            AlterColumn("dbo.MilkEntryUploads", "_31", c => c.Double(nullable: true));
            AlterColumn("dbo.MilkEntryUploads", "TotalMilk", c => c.Double(nullable: true));
            AlterColumn("dbo.MilkEntryUploads", "Amount", c => c.Double(nullable: true));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.MilkEntryUploads", "Amount", c => c.Int(nullable: true));
            AlterColumn("dbo.MilkEntryUploads", "TotalMilk", c => c.Int(nullable: true));
            AlterColumn("dbo.MilkEntryUploads", "_31", c => c.Int(nullable: true));
            AlterColumn("dbo.MilkEntryUploads", "_30", c => c.Int(nullable: true));
            AlterColumn("dbo.MilkEntryUploads", "_29", c => c.Int(nullable: true));
            AlterColumn("dbo.MilkEntryUploads", "_28", c => c.Int(nullable: true));
            AlterColumn("dbo.MilkEntryUploads", "_27", c => c.Int(nullable: true));
            AlterColumn("dbo.MilkEntryUploads", "_26", c => c.Int(nullable: true));
            AlterColumn("dbo.MilkEntryUploads", "_25", c => c.Int(nullable: true));
            AlterColumn("dbo.MilkEntryUploads", "_24", c => c.Int(nullable: true));
            AlterColumn("dbo.MilkEntryUploads", "_23", c => c.Int(nullable: true));
            AlterColumn("dbo.MilkEntryUploads", "_22", c => c.Int(nullable: true));
            AlterColumn("dbo.MilkEntryUploads", "_21", c => c.Int(nullable: true));
            AlterColumn("dbo.MilkEntryUploads", "_20", c => c.Int(nullable: true));
            AlterColumn("dbo.MilkEntryUploads", "_19", c => c.Int(nullable: true));
            AlterColumn("dbo.MilkEntryUploads", "_18", c => c.Int(nullable: true));
            AlterColumn("dbo.MilkEntryUploads", "_17", c => c.Int(nullable: true));
            AlterColumn("dbo.MilkEntryUploads", "_16", c => c.Int(nullable: true));
            AlterColumn("dbo.MilkEntryUploads", "_15", c => c.Int(nullable: true));
            AlterColumn("dbo.MilkEntryUploads", "_14", c => c.Int(nullable: true));
            AlterColumn("dbo.MilkEntryUploads", "_13", c => c.Int(nullable: true));
            AlterColumn("dbo.MilkEntryUploads", "_12", c => c.Int(nullable: true));
            AlterColumn("dbo.MilkEntryUploads", "_11", c => c.Int(nullable: true));
            AlterColumn("dbo.MilkEntryUploads", "_10", c => c.Int(nullable: true));
            AlterColumn("dbo.MilkEntryUploads", "_9", c => c.Int(nullable: true));
            AlterColumn("dbo.MilkEntryUploads", "_8", c => c.Int(nullable: true));
            AlterColumn("dbo.MilkEntryUploads", "_7", c => c.Int(nullable: true));
            AlterColumn("dbo.MilkEntryUploads", "_6", c => c.Int(nullable: true));
            AlterColumn("dbo.MilkEntryUploads", "_5", c => c.Int(nullable: true));
            AlterColumn("dbo.MilkEntryUploads", "_4", c => c.Int(nullable: true));
            AlterColumn("dbo.MilkEntryUploads", "_3", c => c.Int(nullable: true));
            AlterColumn("dbo.MilkEntryUploads", "_2", c => c.Int(nullable: true));
            AlterColumn("dbo.MilkEntryUploads", "_1", c => c.Int(nullable: true));
        }
    }
}
