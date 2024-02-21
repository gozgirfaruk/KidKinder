namespace KidKinder.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateContact : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.SendMesses", "ContactID", c => c.Int(nullable: false));
            DropColumn("dbo.SendMesses", "UserName");
            DropColumn("dbo.SendMesses", "UserMail");
        }
        
        public override void Down()
        {
            AddColumn("dbo.SendMesses", "UserMail", c => c.String());
            AddColumn("dbo.SendMesses", "UserName", c => c.String());
            DropColumn("dbo.SendMesses", "ContactID");
        }
    }
}
