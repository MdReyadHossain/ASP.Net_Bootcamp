 namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class catagory_validation_removed : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Catagories", "Name", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Catagories", "Name", c => c.String(nullable: false));
        }
    }
}
