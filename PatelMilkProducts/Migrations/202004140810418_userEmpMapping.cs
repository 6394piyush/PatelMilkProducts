namespace PatelMilkProducts.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class userEmpMapping : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.UserEmpMappings",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UsersId = c.Int(nullable: false),
                        EmployeesId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Employees", t => t.EmployeesId, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.UsersId, cascadeDelete: true)
                .Index(t => t.UsersId)
                .Index(t => t.EmployeesId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.UserEmpMappings", "UsersId", "dbo.Users");
            DropForeignKey("dbo.UserEmpMappings", "EmployeesId", "dbo.Employees");
            DropIndex("dbo.UserEmpMappings", new[] { "EmployeesId" });
            DropIndex("dbo.UserEmpMappings", new[] { "UsersId" });
            DropTable("dbo.UserEmpMappings");
        }
    }
}
