namespace MOVIEZ_.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class movieValidation : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Movies", "ReleaseDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Movies", "Description", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Movies", "Description", c => c.String());
            AlterColumn("dbo.Movies", "ReleaseDate", c => c.Int(nullable: false));
        }
    }
}
