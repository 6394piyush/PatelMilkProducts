namespace PatelMilkProducts.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EmpAccountCreation : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.EmpAccounts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        EmployeesId = c.Int(nullable: false),
                        Amount = c.Int(nullable: false),
                        TransactionType = c.String(),
                        Signature = c.String(),
                        Comments = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Employees", t => t.EmployeesId, cascadeDelete: true)
                .Index(t => t.EmployeesId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.EmpAccounts", "EmployeesId", "dbo.Employees");
            DropIndex("dbo.EmpAccounts", new[] { "EmployeesId" });
            DropTable("dbo.EmpAccounts");
        }
    }
}
