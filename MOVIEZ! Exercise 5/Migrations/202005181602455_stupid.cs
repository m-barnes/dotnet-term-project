namespace MOVIEZ_.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class stupid : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Customers", "Name", c => c.String(nullable: false, maxLength: 45));
            AlterColumn("dbo.Customers", "street_address", c => c.String(nullable: false, maxLength: 30));
            AlterColumn("dbo.Customers", "city_address", c => c.String(nullable: false, maxLength: 30));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Customers", "city_address", c => c.String(nullable: false));
            AlterColumn("dbo.Customers", "street_address", c => c.String(nullable: false));
            AlterColumn("dbo.Customers", "Name", c => c.String(nullable: false, maxLength: 255));
        }
    }
}
