namespace MVC5Final.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DbFile : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.DbFiles",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Size = c.Int(nullable: false),
                        MimeType = c.String(),
                        Content = c.Binary(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.DbFiles");
        }
    }
}
