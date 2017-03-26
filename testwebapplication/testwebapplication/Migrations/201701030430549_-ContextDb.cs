namespace testwebapplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ContextDb : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.reviewsdatas", "Body", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.reviewsdatas", "Body", c => c.String());
        }
    }
}
