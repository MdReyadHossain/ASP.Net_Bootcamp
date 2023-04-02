namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DBinitialized : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Catagories",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.News",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false),
                        Description = c.String(nullable: false),
                        Cid = c.Int(nullable: false),
                        Date = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Catagories", t => t.Cid, cascadeDelete: true)
                .Index(t => t.Cid);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.News", "Cid", "dbo.Catagories");
            DropIndex("dbo.News", new[] { "Cid" });
            DropTable("dbo.News");
            DropTable("dbo.Catagories");
        }
    }
}
