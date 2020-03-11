namespace PatelMilkProducts.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Blankrevert : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Employees", "RegistrationId", "dbo.Registrations");
            DropForeignKey("dbo.RolePermissionMappings", "PermissionsId", "dbo.Permissions");
            DropForeignKey("dbo.RolePermissionMappings", "RoleId", "dbo.Roles");
            DropForeignKey("dbo.UserRoleMappings", "RegistrationId", "dbo.Registrations");
            DropForeignKey("dbo.UserRoleMappings", "RoleId", "dbo.Roles");
            DropIndex("dbo.Employees", new[] { "RegistrationId" });
            DropIndex("dbo.RolePermissionMappings", new[] { "RoleId" });
            DropIndex("dbo.RolePermissionMappings", new[] { "PermissionsId" });
            DropIndex("dbo.UserRoleMappings", new[] { "RegistrationId" });
            DropIndex("dbo.UserRoleMappings", new[] { "RoleId" });
            DropColumn("dbo.Employees", "RegistrationId");
            DropTable("dbo.Registrations");
            DropTable("dbo.Permissions");
            DropTable("dbo.RolePermissionMappings");
            DropTable("dbo.Roles");
            DropTable("dbo.UserRoleMappings");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.UserRoleMappings",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        RegistrationId = c.Int(nullable: false),
                        RoleId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Roles",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        RoleName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.RolePermissionMappings",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        RoleId = c.Int(nullable: false),
                        PermissionsId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Permissions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Registrations",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserName = c.String(),
                        Password = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Employees", "RegistrationId", c => c.Int(nullable: false));
            CreateIndex("dbo.UserRoleMappings", "RoleId");
            CreateIndex("dbo.UserRoleMappings", "RegistrationId");
            CreateIndex("dbo.RolePermissionMappings", "PermissionsId");
            CreateIndex("dbo.RolePermissionMappings", "RoleId");
            CreateIndex("dbo.Employees", "RegistrationId");
            AddForeignKey("dbo.UserRoleMappings", "RoleId", "dbo.Roles", "Id", cascadeDelete: true);
            AddForeignKey("dbo.UserRoleMappings", "RegistrationId", "dbo.Registrations", "Id", cascadeDelete: true);
            AddForeignKey("dbo.RolePermissionMappings", "RoleId", "dbo.Roles", "Id", cascadeDelete: true);
            AddForeignKey("dbo.RolePermissionMappings", "PermissionsId", "dbo.Permissions", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Employees", "RegistrationId", "dbo.Registrations", "Id", cascadeDelete: true);
        }
    }
}
