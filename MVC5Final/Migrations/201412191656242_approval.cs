namespace MVC5Final.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class approval : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.GuestTables", "approval", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.GuestTables", "approval");
        }
    }
}
