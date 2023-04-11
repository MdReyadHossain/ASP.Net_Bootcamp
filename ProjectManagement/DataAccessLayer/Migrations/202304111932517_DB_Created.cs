namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DB_Created : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Members",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Role = c.String(nullable: false),
                        Project_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Projects", t => t.Project_Id)
                .Index(t => t.Project_Id);
            
            CreateTable(
                "dbo.Projects",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false),
                        Status = c.String(nullable: false),
                        StartDate = c.String(nullable: false),
                        EndDate = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Members", "Project_Id", "dbo.Projects");
            DropIndex("dbo.Members", new[] { "Project_Id" });
            DropTable("dbo.Projects");
            DropTable("dbo.Members");
        }
    }
}
