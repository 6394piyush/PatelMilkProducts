namespace PatelMilkProducts.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class userroleupdate : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.UserRoleMappings", "RoleMaster_Id", "dbo.RoleMasters");
            DropForeignKey("dbo.UserRoleMappings", "Users_Id", "dbo.Users");
            DropIndex("dbo.UserRoleMappings", new[] { "RoleMaster_Id" });
            DropIndex("dbo.UserRoleMappings", new[] { "Users_Id" });
            DropColumn("dbo.UserRoleMappings", "RoleMaster_Id");
            DropColumn("dbo.UserRoleMappings", "Users_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.UserRoleMappings", "Users_Id", c => c.Int());
            AddColumn("dbo.UserRoleMappings", "RoleMaster_Id", c => c.Int());
            CreateIndex("dbo.UserRoleMappings", "Users_Id");
            CreateIndex("dbo.UserRoleMappings", "RoleMaster_Id");
            AddForeignKey("dbo.UserRoleMappings", "Users_Id", "dbo.Users", "Id");
            AddForeignKey("dbo.UserRoleMappings", "RoleMaster_Id", "dbo.RoleMasters", "Id");
        }
    }
}
