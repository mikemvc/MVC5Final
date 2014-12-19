namespace MVC5Final.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Method : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.SystemLogs", "Method", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.SystemLogs", "Method");
        }
    }
}
