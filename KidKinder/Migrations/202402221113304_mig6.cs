namespace KidKinder.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig6 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Teachers", "BranchID", c => c.Int(nullable: false));
            CreateIndex("dbo.Teachers", "BranchID");
            AddForeignKey("dbo.Teachers", "BranchID", "dbo.Branches", "BranchID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Teachers", "BranchID", "dbo.Branches");
            DropIndex("dbo.Teachers", new[] { "BranchID" });
            DropColumn("dbo.Teachers", "BranchID");
        }
    }
}
