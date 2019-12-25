namespace PatelMilkProducts.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MilkEntryUpload : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.MilkEntryUploads",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        VillageName = c.String(),
                        EmployeeNameHindi = c.String(),
                        _1 = c.Int(nullable: false),
                        _2 = c.Int(nullable: false),
                        _3 = c.Int(nullable: false),
                        _4 = c.Int(nullable: false),
                        _5 = c.Int(nullable: false),
                        _6 = c.Int(nullable: false),
                        _7 = c.Int(nullable: false),
                        _8 = c.Int(nullable: false),
                        _9 = c.Int(nullable: false),
                        _10 = c.Int(nullable: false),
                        _11 = c.Int(nullable: false),
                        _12 = c.Int(nullable: false),
                        _13 = c.Int(nullable: false),
                        _14 = c.Int(nullable: false),
                        _15 = c.Int(nullable: false),
                        _16 = c.Int(nullable: false),
                        _17 = c.Int(nullable: false),
                        _18 = c.Int(nullable: false),
                        _19 = c.Int(nullable: false),
                        _20 = c.Int(nullable: false),
                        _21 = c.Int(nullable: false),
                        _22 = c.Int(nullable: false),
                        _23 = c.Int(nullable: false),
                        _24 = c.Int(nullable: false),
                        _25 = c.Int(nullable: false),
                        _26 = c.Int(nullable: false),
                        _27 = c.Int(nullable: false),
                        _28 = c.Int(nullable: false),
                        _29 = c.Int(nullable: false),
                        _30 = c.Int(nullable: false),
                        _31 = c.Int(nullable: false),
                        TotalMilk = c.Int(nullable: false),
                        Amount = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.MilkEntryUploads");
        }
    }
}
