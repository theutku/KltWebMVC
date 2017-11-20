namespace Kalitte.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.News",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Header = c.String(nullable: false, maxLength: 50),
                        Body = c.String(nullable: false, maxLength: 300),
                        CreationDate = c.DateTime(nullable: false),
                        SelectedNewsCategory = c.String(nullable: false),
                        ApplicationUserId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.ApplicationUserId, cascadeDelete: true)
                .Index(t => t.ApplicationUserId);
            
            DropTable("dbo.NewsModels");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.NewsModels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Header = c.String(nullable: false, maxLength: 50),
                        Body = c.String(nullable: false, maxLength: 300),
                        CreatedBy = c.String(),
                        CreationDate = c.String(),
                        SelectedNewsCategory = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            DropForeignKey("dbo.News", "ApplicationUserId", "dbo.AspNetUsers");
            DropIndex("dbo.News", new[] { "ApplicationUserId" });
            DropTable("dbo.News");
        }
    }
}
