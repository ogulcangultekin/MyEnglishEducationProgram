namespace DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.tab_Bilgiler",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Soru = c.String(nullable: false, maxLength: 50),
                        Cevap = c.String(nullable: false, maxLength: 50),
                        EklemeTarihi = c.DateTime(),
                        TurengLink = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.tab_Bilgiler");
        }
    }
}
