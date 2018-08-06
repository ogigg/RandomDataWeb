namespace RandomDataWeb.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class LastNameTableAdded : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.LastNames",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NameMale = c.String(),
                        NameFemale = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.LastNames");
        }
    }
}
