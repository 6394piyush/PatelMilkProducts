namespace PatelMilkProducts.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class BlankRevert : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.EmpAccounts", "EmployeesId", "dbo.Employees");
            DropForeignKey("dbo.MilkEntryUploads", "EmployeesId", "dbo.Employees");
            DropIndex("dbo.EmpAccounts", new[] { "EmployeesId" });
            DropIndex("dbo.MilkEntryUploads", new[] { "EmployeesId" });
            DropTable("dbo.EmpAccounts");
            DropTable("dbo.MilkEntryUploads");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.MilkEntryUploads",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        EmployeesId = c.Int(nullable: false),
                        SYear = c.String(),
                        SMonth = c.String(),
                        _1 = c.Double(nullable: false),
                        _2 = c.Double(nullable: false),
                        _3 = c.Double(nullable: false),
                        _4 = c.Double(nullable: false),
                        _5 = c.Double(nullable: false),
                        _6 = c.Double(nullable: false),
                        _7 = c.Double(nullable: false),
                        _8 = c.Double(nullable: false),
                        _9 = c.Double(nullable: false),
                        _10 = c.Double(nullable: false),
                        _11 = c.Double(nullable: false),
                        _12 = c.Double(nullable: false),
                        _13 = c.Double(nullable: false),
                        _14 = c.Double(nullable: false),
                        _15 = c.Double(nullable: false),
                        _16 = c.Double(nullable: false),
                        _17 = c.Double(nullable: false),
                        _18 = c.Double(nullable: false),
                        _19 = c.Double(nullable: false),
                        _20 = c.Double(nullable: false),
                        _21 = c.Double(nullable: false),
                        _22 = c.Double(nullable: false),
                        _23 = c.Double(nullable: false),
                        _24 = c.Double(nullable: false),
                        _25 = c.Double(nullable: false),
                        _26 = c.Double(nullable: false),
                        _27 = c.Double(nullable: false),
                        _28 = c.Double(nullable: false),
                        _29 = c.Double(nullable: false),
                        _30 = c.Double(nullable: false),
                        _31 = c.Double(nullable: false),
                        TotalMilk = c.Double(nullable: false),
                        Amount = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.EmpAccounts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        EmployeesId = c.Int(nullable: false),
                        Amount = c.Int(nullable: false),
                        TransactionType = c.String(),
                        CurrDate = c.DateTime(nullable: false),
                        Signature = c.String(),
                        Comments = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateIndex("dbo.MilkEntryUploads", "EmployeesId");
            CreateIndex("dbo.EmpAccounts", "EmployeesId");
            AddForeignKey("dbo.MilkEntryUploads", "EmployeesId", "dbo.Employees", "Id", cascadeDelete: true);
            AddForeignKey("dbo.EmpAccounts", "EmployeesId", "dbo.Employees", "Id", cascadeDelete: true);
        }
    }
}
