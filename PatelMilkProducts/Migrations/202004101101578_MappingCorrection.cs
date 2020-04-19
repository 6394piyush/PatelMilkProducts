namespace PatelMilkProducts.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MappingCorrection : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.UserRoleMappings", "UsersId", c => c.Int(nullable: false));
            AddColumn("dbo.UserRoleMappings", "RoleMasterId", c => c.Int(nullable: false));
            CreateIndex("dbo.UserRoleMappings", "UsersId");
            CreateIndex("dbo.UserRoleMappings", "RoleMasterId");
            AddForeignKey("dbo.UserRoleMappings", "RoleMasterId", "dbo.RoleMasters", "Id", cascadeDelete: true);
            AddForeignKey("dbo.UserRoleMappings", "UsersId", "dbo.Users", "Id", cascadeDelete: true);
            DropColumn("dbo.UserRoleMappings", "UserId");
            DropColumn("dbo.UserRoleMappings", "RoleId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.UserRoleMappings", "RoleId", c => c.Int(nullable: false));
            AddColumn("dbo.UserRoleMappings", "UserId", c => c.Int(nullable: false));
            DropForeignKey("dbo.UserRoleMappings", "UsersId", "dbo.Users");
            DropForeignKey("dbo.UserRoleMappings", "RoleMasterId", "dbo.RoleMasters");
            DropIndex("dbo.UserRoleMappings", new[] { "RoleMasterId" });
            DropIndex("dbo.UserRoleMappings", new[] { "UsersId" });
            DropColumn("dbo.UserRoleMappings", "RoleMasterId");
            DropColumn("dbo.UserRoleMappings", "UsersId");
        }
    }
}
