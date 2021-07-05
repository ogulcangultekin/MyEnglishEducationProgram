namespace DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v12 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.tab_Bilgiler", "TurengLink", c => c.String(nullable: false, maxLength: 500));
        }
        
        public override void Down()
        {
            DropColumn("dbo.tab_Bilgiler", "TurengLink");
        }
    }
}
