namespace MVC5Final.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class GuestTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.GuestTables",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Subject = c.String(),
                        Content = c.String(),
                        PostDateTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.GuestTables");
        }
    }
}
