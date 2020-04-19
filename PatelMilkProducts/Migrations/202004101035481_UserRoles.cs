namespace PatelMilkProducts.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UserRoles : DbMigration
    {
        public override void Up()
        {
            CreateTable(
               "dbo.Users",
               c => new
               {
                   Id = c.Int(nullable: false, identity: true),
                   Username = c.String(),
                   UserPassword = c.String(),
               })
               .PrimaryKey(t => t.Id);

            CreateTable(
                "dbo.RoleMasters",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        RoleName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.UserRoleMappings",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.Int(nullable: false),
                        RoleId = c.Int(nullable: false),
                        RoleMaster_Id = c.Int(),
                        Users_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.RoleMasters", t => t.RoleMaster_Id)
                .ForeignKey("dbo.Users", t => t.Users_Id)
                .Index(t => t.RoleMaster_Id)
                .Index(t => t.Users_Id);
            
           
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.UserRoleMappings", "Users_Id", "dbo.Users");
            DropForeignKey("dbo.UserRoleMappings", "RoleMaster_Id", "dbo.RoleMasters");
            DropIndex("dbo.UserRoleMappings", new[] { "Users_Id" });
            DropIndex("dbo.UserRoleMappings", new[] { "RoleMaster_Id" });
            DropTable("dbo.Users");
            DropTable("dbo.UserRoleMappings");
            DropTable("dbo.RoleMasters");
        }
    }
}
