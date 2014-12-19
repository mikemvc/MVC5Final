namespace MVC5Final.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UserName : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.SystemLogs", "UserName", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.SystemLogs", "UserName");
        }
    }
}
