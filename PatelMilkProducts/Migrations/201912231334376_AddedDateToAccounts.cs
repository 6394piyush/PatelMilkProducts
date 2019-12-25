namespace PatelMilkProducts.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedDateToAccounts : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.EmpAccounts", "CurrDate", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.EmpAccounts", "CurrDate");
        }
    }
}
