namespace DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v11 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.tab_Bilgiler", "TurengLink");
        }
        
        public override void Down()
        {
            AddColumn("dbo.tab_Bilgiler", "TurengLink", c => c.String(nullable: false, maxLength: 50));
        }
    }
}
