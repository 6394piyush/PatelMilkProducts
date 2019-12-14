namespace PatelMilkProducts.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class KhaliPriceRate : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Khalis", "Rate", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Khalis", "Rate");
        }
    }
}
