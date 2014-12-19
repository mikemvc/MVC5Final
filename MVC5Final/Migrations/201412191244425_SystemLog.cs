namespace MVC5Final.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SystemLog : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.SystemLogs",
                c => new
                    {
                        LogId = c.Int(nullable: false, identity: true),
                        ControllerName = c.String(),
                        ActionName = c.String(),
                        IPAddress = c.String(),
                        CreatedDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.LogId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.SystemLogs");
        }
    }
}
