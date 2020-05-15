namespace MOVIEZ_.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedGenre : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Customers", "email_address", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Customers", "email_address", c => c.String(nullable: false));
        }
    }
}
