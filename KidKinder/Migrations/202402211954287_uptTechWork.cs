namespace KidKinder.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class uptTechWork : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Teachers", "WorkTime", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Teachers", "WorkTime");
        }
    }
}
