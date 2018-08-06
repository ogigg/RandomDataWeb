namespace RandomDataWeb.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.RandomDataViewModels",
                c => new
                    {
                        FirstName = c.String(nullable: false, maxLength: 128),
                        LastName = c.String(),
                        Street = c.String(),
                        Number = c.Byte(nullable: false),
                        ZipCode = c.String(),
                        City = c.String(),
                        Country = c.String(),
                    })
                .PrimaryKey(t => t.FirstName);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.RandomDataViewModels");
        }
    }
}
