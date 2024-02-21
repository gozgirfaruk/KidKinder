namespace KidKinder.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MessageUpdate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.SendMesses",
                c => new
                    {
                        SendMessID = c.Int(nullable: false, identity: true),
                        UserName = c.String(),
                        UserMail = c.String(),
                        MessHeader = c.String(),
                        Message = c.String(),
                    })
                .PrimaryKey(t => t.SendMessID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.SendMesses");
        }
    }
}
