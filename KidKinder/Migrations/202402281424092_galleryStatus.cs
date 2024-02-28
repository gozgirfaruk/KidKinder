namespace KidKinder.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class galleryStatus : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Galleries", "Status", c => c.Int(nullable: true));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Galleries", "Status");
        }
    }
}
